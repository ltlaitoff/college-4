import { Cards, Promo } from './components'

import './Home.scss'
import { Component, createElement } from 'lib'
import { createComponent } from '../../../packages/reactiveLibrary/virtual_dom'
import { addWatcher, getStore } from '../../store'

interface HomeProps {
	onSignIn: () => void
}

interface HomeState {
	logged: boolean
}

class Home extends Component<HomeProps, HomeState> {
	state = {
		logged: false
	}

	componentDidMount() {
		const getLogged = () => {
			const store = getStore()
			this.setState(_ => ({
				logged: store.logged
			}))
		}

		addWatcher(getLogged)
	}

	render() {
		console.log(this.props)
		return createElement(
			'div',
			{
				key: 'home',
				className: 'home-page'
			},
			createComponent(Promo, { key: 'home-promo' }),
			createComponent(Cards, {
				key: 'home-cards',
				onSignIn: () => this.props.onSignIn(),
				logged: this.state.logged
			})
		)
	}
}

export default Home
