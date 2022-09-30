import { createElement } from 'helpers'

import './ShoppingCartCard.scss'
const ShoppingCartCard = ({ title, price, count }) => {
	const card = createElement('div', {
		className: 'shopping-cart--card',
		childs: [
			createElement('h4', {
				className: 'shopping-cart--card-title',
				textContent: title
			}),
			createElement('div', {
				className: 'shopping-cart--card-wrapper',
				childs: [
					createElement('div', {
						className: 'shopping-cart--card-price',
						textContent: price
					}),
					createElement('div', {
						className: 'shopping-cart--card-buttons',
						childs: [
							createElement('button', {
								className: 'shopping-cart--card-button',
								textContent: '-'
							}),
							createElement('span', {
								className: 'shopping-cart--card-count',
								textContent: count
							}),
							createElement('button', {
								className: 'shopping-cart--card-button',
								textContent: '+'
							})
						]
					})
				]
			})
		]
	})

	return card
}

export default ShoppingCartCard

/*
<li className="shopping-cart--card">
				<div className="shopping-cart--card-title"></div>
				<div className="shopping-cart--card-price"></div>
				<div className="shopping-cart--card-buttons">
					<button className="shopping-cart--card-button"></button>
					<span className="shopping-cart--card-count"></span>
					<div className="shopping-cart--card-button"></div>
				</div>
			</li>
*/
