// import LoadIcon from 'components/LoadIcon'

import './Card.scss'
import { route } from 'router'
import { Component, createElement } from 'lib'
import StarIcon from '../../../../assets/images/favicons/star.svg'

interface CardProps {
	id: number
	name: string
	stars: number
	image: string
	minPrice: number
	time: number
	type: string
	onCardClick: (id: number) => void
}

class Card extends Component<CardProps, {}> {
	public componentDidMount(): void {
		const cardInner = document.querySelector(`.card-${this.props.id}`)

		// @ts-expect-error Style
		cardInner.style.setProperty('--animate-delay', `.${this.props.id / 2}s`)
		cardInner.classList.add('animate__animated', 'animate__fadeInUp')
	}

	render() {
		const formattedPrice = `Від ${this.props.minPrice} ₴`
		const formattedTime = `${this.props.time} хв.`

		return createElement(
			'a',
			{
				key: `card-a-${this.props.id}`,
				className: `card card-${this.props.id} animate__animated animate__fadeInUp`,
				onclick: () => this.props.onCardClick(this.props.id)
			},
			createElement('div', {
				key: 'card--image',
				className: 'card--image',
				style: `background-image: url(${this.props.image})`
			}),
			createElement(
				'div',
				{
					key: 'card--body',
					className: 'card--body'
				},
				createElement(
					'div',
					{
						key: 'card--head-wrapper',
						className: 'card--head-wrapper'
					},
					createElement('h3', {
						key: 'card--title',
						className: 'card--title',
						onClick: () => {
							console.log('click')
						},
						textContent: this.props.name
					}),
					createElement('div', {
						key: 'card--time',
						className: 'card--time',
						textContent: formattedTime
					})
				),
				createElement(
					'div',
					{
						key: 'card--bottom-wrapper',
						className: 'card--bottom-wrapper'
					},
					createElement(
						'div',
						{
							key: 'card--stars',
							className: 'card--stars'
						},
						createElement('div', {
							key: 'card--stars-svg',
							className: 'card--star',
							innerHTML: StarIcon
						}),
						createElement('div', {
							key: 'card--stars-text',
							textContent: this.props.stars
						})
					),
					createElement(
						'div',
						{
							key: 'card--bottom-inner-wrapper',
							className: 'card--bottom-inner-wrapper'
						},
						createElement('div', {
							key: 'card--price',
							className: 'card--price',
							textContent: formattedPrice
						}),
						createElement('div', {
							key: 'card--dote',
							className: 'card--dote'
						}),
						createElement('div', {
							key: 'card--type',
							className: 'card--type',
							textContent: this.props.type
						})
					)
				)
			)
		)
	}
}

export default Card
