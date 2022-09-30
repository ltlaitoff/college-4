import { createElement } from 'helpers'
import {
	ShoppingCartHeader,
	ShoppingCartCards,
	ShoppingCartFooter
} from './components'

import './ShoppingCart.scss'

const ShoppingCart = () => {
	const shoppingCart = createElement('div', {
		className: 'shopping-cart',
		child: createElement('div', {
			className: 'shopping-cart--body',
			childs: [ShoppingCartHeader(), ShoppingCartCards(), ShoppingCartFooter()]
		})
	})

	/* <div className="shopping-cart"></div>
	<div className="shopping-cart--body">
		<div className="shopping-cart--header">
			<h3 className="shopping-cart--header-title"></h3>
			<button className="shopping-cart--cross"></button>
		</div>
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
		<div className="shopping-cart--footer">
			<div className="shopping-cart--all-price"></div>
			<button className="shopping-cart--create-order"></button>
			<button className="shopping-cart--cancel"></button>
		</div>
	</div>
</div>*/

	return shoppingCart
}

export default ShoppingCart
