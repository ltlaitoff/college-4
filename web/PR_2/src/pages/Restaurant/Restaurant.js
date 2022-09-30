import { createElement } from 'helpers'
import { RestaurantCards, RestaurantHeader } from './components'

import './Restaurant.scss'
import { route } from 'router'

const Restaurant = params => {
	if (params.toString() === '') {
		route('/')
	}

	const cards = RestaurantCards(params.get('id'))

	return createElement('div', {
		className: 'restaurant',
		childs: [RestaurantHeader(), cards]
	})
}

export default Restaurant
