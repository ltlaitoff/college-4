import { getRestaurants } from 'api'
// import LoadIcon from 'components/LoadIcon'

import SearchIcon from '../../../../assets/images/favicons/search.svg'
import { Card } from '..'

import './Cards.scss'
import { Component, createElement } from 'lib'
import { createComponent } from '../../../../../packages/reactiveLibrary/virtual_dom'
import { route } from '../../../../router'

interface CardsProps {
	logged: boolean
	onSignIn: () => void
}

class Cards extends Component<CardsProps, {}> {
	// TODO: Change it to import from async and rerender
	restaurants = [...getRestaurants()]

	onCardClick(id: number) {
		console.log(this.props)

		if (this.props.logged === false) {
			this.props.onSignIn()
			return
		}

		route('/restaurant', [{ id: id }])
	}

	render() {
		console.log(this.props)

		return createElement(
			'div',
			{
				key: 'home-cards',
				className: 'cards'
			},
			createElement(
				'div',
				{
					key: 'home-cards-head-wrapper',
					className: 'cards--head-wrapper'
				},
				createElement('h2', {
					key: 'home-cards-title',
					className: 'cards--title',
					textContent: 'Ресторани'
				}),
				createElement(
					'div',
					{
						key: 'cards-filter',
						className: 'cards--filter'
					},
					createElement('div', {
						key: 'cards--filter-icon',
						className: 'cards--filter-icon',
						innerHTML: SearchIcon
					}),
					createElement('input', {
						key: 'cards--filter-input',
						className: 'cards--filter-input',
						type: 'text',
						placeholder: 'Пошук страв та ресторанів'
					})
				)
			),
			createElement(
				'div',
				{
					key: 'cards--wrapper',
					className: 'cards--wrapper'
				},
				...this.restaurants.map(info =>
					createComponent(Card, {
						key: `card-${info.id}`,
						onCardClick: (id: number) => this.onCardClick(id),
						...info
					})
				)
			)
		)
	}
}

export default Cards
