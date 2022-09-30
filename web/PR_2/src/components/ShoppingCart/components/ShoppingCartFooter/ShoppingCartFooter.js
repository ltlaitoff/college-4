import './ShoppingCartFooter.scss'
import { createElement, removeShoppingCart } from 'helpers'

const ShoppingCartFooter = () => {
	const closeButton = createElement('button', {
		className: 'shopping-cart--footer-cancel',
		textContent: 'Відміна'
	})
	closeButton.addEventListener('click', () => removeShoppingCart())

	const footer = createElement('div', {
		className: 'shopping-cart--footer',
		childs: [
			createElement('div', {
				className: 'shopping-cart--footer-all-price',
				textContent: '1250'
			}),
			createElement('div', {
				className: 'shopping-cart--footer-wrapper',
				childs: [
					createElement('button', {
						className: 'shopping-cart--footer-create-order',
						textContent: 'Оформити замовлення'
					}),
					closeButton
				]
			})
		]
	})
	return footer
}

export default ShoppingCartFooter

/*
<div className="shopping-cart--footer">
			<div className="shopping-cart--all-price"></div>
			<button className="shopping-cart--create-order"></button>
			<button className="shopping-cart--cancel"></button>
		</div>
*/
