import { Component, createElement } from 'lib'
import Home from '../../assets/images/favicons/home.svg'
import './Logo.scss'

class Logo extends Component<{}, {}> {
	render() {
		return createElement(
			'a',
			{
				key: 'logo',
				href: '#',
				className: 'logo'
			},
			createElement('div', {
				key: 'logo--image',
				className: 'logo--image',
				innerHTML: Home
			}),
			createElement('h1', {
				key: 'logo--text',
				className: 'logo--text',
				innerHTML: 'Delivery<br />food'
			})
		)
	}
}

export default Logo
