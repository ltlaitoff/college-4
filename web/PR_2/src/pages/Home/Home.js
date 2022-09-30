import { Cards, Promo } from './components'
import { createElement } from 'helpers'

import './Home.scss'

const Home = () => {
	const homeElement = createElement('div', {
		className: 'home-page',
		childs: [Promo(), Cards()]
	})

	return homeElement
}

export default Home
