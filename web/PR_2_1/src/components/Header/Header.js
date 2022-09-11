import SingInIcon from '../../assets/images/favicons/user.svg'
import ShoppingCartIcon from '../../assets/images/favicons/shopping-cart.svg'
import Logo from '../Logo'
import Search from '../Search'
import ButtonWithIconAndText from '../ButtonWithIconAndText'

import { createElement } from '../../helpers/createElement'
import './Header.scss'

const Header = () => {
	const signInButton = ButtonWithIconAndText({
		buttonClass: 'header--button header--button-signin',
		iconClass: 'header--button-icon header--button-signin-icon',
		iconSrc: SingInIcon,
		text: 'Війти'
	})

	const shoppingCartButton = ButtonWithIconAndText({
		buttonClass: 'header--button header--button-shopping-cart',
		iconClass: 'header--button-icon header--button-shopping-cart-icon',
		iconSrc: ShoppingCartIcon,
		text: 'Корзина'
	})

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
