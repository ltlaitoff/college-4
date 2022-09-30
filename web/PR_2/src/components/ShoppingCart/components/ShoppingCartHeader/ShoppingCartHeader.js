import './ShoppingCartHeader.scss'
import { createElement, removeShoppingCart } from 'helpers'
import LoadIcon from 'components/LoadIcon'

const ShoppingCartHeader = () => {
	const button = createElement('button', {
		className: 'shopping-cart--header-cross-button',
		child: LoadIcon('cross', 'shopping-cart--header-cross')
	})

	button.addEventListener('click', () => removeShoppingCart())

	const header = createElement('div', {
		className: 'shopping-cart--header',
		childs: [
			createElement('h3', {
				className: 'shopping-cart--header-title',
				textContent: 'Корзина'
			}),
			button
		]
	})

	return header
}

export default ShoppingCartHeader

/*
	<div className="shopping-cart--header">
			<h3 className="shopping-cart--header-title"></h3>
			<button className="shopping-cart--cross"></button>
		</div>
*/
