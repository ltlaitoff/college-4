import Logo from 'components/Logo'
import Search from './components/Search'
import ButtonWithIconAndText from './components/ButtonWithIconAndText'

import { createElement, openShoppingCart } from 'helpers'
import './Header.scss'

const Header = () => {
	const signInButton = ButtonWithIconAndText({
		buttonClass: 'header--button header--button-signin',
		iconClasses: ['header--button-icon', 'header--button-signin-icon'],
		icon: 'user',
		text: 'Війти'
	})

	const shoppingCartButton = ButtonWithIconAndText({
		buttonClass: 'header--button header--button-shopping-cart',
		iconClasses: ['header--button-icon', 'header--button-shopping-cart-icon'],
		icon: 'shopping-cart',
		text: 'Корзина'
	})

	shoppingCartButton.addEventListener('click', () => openShoppingCart())

	const buttonsWrapper = createElement('div', {
		className: 'header--buttons',
		childs: [signInButton, shoppingCartButton]
	})

	const header = createElement('header', {
		className: 'header',
		childs: [Logo(), Search(), buttonsWrapper]
	})

	return header
}

export default Header
