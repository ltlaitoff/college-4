import { createElement } from 'helpers'
import { getRestaurantDishes } from 'api'
import { RestaurantCard } from '..'

import './RestaurantCards.scss'

const RestaurantCards = id => {
	const cardsInfo = getRestaurantDishes(id)

	const data = cardsInfo.map(item => {
		return { ...item, image: require(`assets/images/${item.image}.jpg`) }
	})

	return createElement('div', {
		className: 'restaurant-cards',
		childs: data.map(item => RestaurantCard(item))
	})
}

export default RestaurantCards
