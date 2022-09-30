import DATA from './data.json'
import { loadAPIImagesRestaurants } from 'helpers'

const getRestaurants = () => {
	return loadAPIImagesRestaurants(DATA.restaurants)
}

const getRestaurantDishes = id => {
	return DATA.restaurantsDishes[id]
}

export { getRestaurantDishes, getRestaurants }
