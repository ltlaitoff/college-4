import { createElement } from 'helpers'
import { ShoppingCartCard } from '..'

import './ShoppingCartCards.scss'

const ShopingCartHeader = () => {
	const cards = createElement('div', {
		className: 'shopping-cart--cards',
		childs: [
			ShoppingCartCard({
				id: 0,
				title: 'Ролл угорь стандартный',
				price: 250,
				count: 1
			})
		]
	})

	return cards
}

export default ShopingCartHeader

/*
<ul className="shopping-cart--cards">
			<li className="shopping-cart--card">
				<div className="shopping-cart--card-title"></div>
				<div className="shopping-cart--card-price"></div>
				<div className="shopping-cart--card-buttons">
					<button className="shopping-cart--card-button"></button>
					<span className="shopping-cart--card-count"></span>
					<div className="shopping-cart--card-button"></div>
				</div>
			</li>
		</ul>
*/
