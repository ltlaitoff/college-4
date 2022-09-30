import { getRestaurants } from 'api'
import { createElement } from 'helpers'
import LoadIcon from 'components/LoadIcon'

import { Card } from '..'

import './Cards.scss'

const Cards = () => {
	const restaurants = [...getRestaurants()]
	// TODO: Change it to import from async and rerender

	const searchIcon = LoadIcon('search', 'cards--filter-icon')

	return createElement('div', {
		className: 'cards',
		childs: [
			createElement('div', {
				className: 'cards--head-wrapper',
				childs: [
					createElement('h2', {
						className: 'cards--title',
						textContent: 'Ресторани'
					}),
					createElement('div', {
						className: 'cards--filter',
						childs: [
							searchIcon,
							createElement('input', {
								className: 'cards--filter-input',
								type: 'text',
								placeholder: 'Пошук страв та ресторанів'
							})
						]
					})
				]
			}),
			createElement('div', {
				className: 'cards--wrapper',
				childs: restaurants.map(info => Card(info))
			})
		]
	})
}

export default Cards
