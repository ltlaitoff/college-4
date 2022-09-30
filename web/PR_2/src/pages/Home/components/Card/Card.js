import LoadIcon from 'components/LoadIcon'
import { createElement } from 'helpers'

import './Card.scss'
import { route } from 'router'

const Card = ({ id, name, stars, image, minPrice, time, type }) => {
	const StarElement = LoadIcon('star', 'card--star')

	const formattedPrice = `Від ${minPrice} ₴`
	const formattedTime = `${time} хв.`

	const card = createElement('a', {
		className: 'card',
		onClick: () => {
			console.log('click')
		},
		childs: [
			createElement('div', {
				className: 'card--image',
				onClick: () => {
					console.log('click')
				},
				style: `background-image: url(${image})`
			}),
			createElement('div', {
				className: 'card--body',
				childs: [
					createElement('div', {
						className: 'card--head-wrapper',
						childs: [
							createElement('h3', {
								className: 'card--title',
								onClick: () => {
									console.log('click')
								},
								textContent: name
							}),
							createElement('div', {
								className: 'card--time',
								textContent: formattedTime
							})
						]
					}),
					createElement('div', {
						className: 'card--bottom-wrapper',
						childs: [
							createElement('div', {
								className: 'card--stars',
								childs: [StarElement, stars]
							}),
							createElement('div', {
								className: 'card--bottom-inner-wrapper',
								childs: [
									createElement('div', {
										className: 'card--price',
										textContent: formattedPrice
									}),
									createElement('div', {
										className: 'card--dote'
									}),
									createElement('div', {
										className: 'card--type',
										textContent: type
									})
								]
							})
						]
					})
				]
			})
		]
	})

	card.addEventListener('click', () => route('/restaurant', [{ id: id }]))

	card.style.setProperty('--animate-delay', `.${id / 2}s`)
	card.classList.add('animate__animated', 'animate__fadeInUp')

	return card
}

export default Card
