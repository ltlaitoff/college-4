import Search from './components/Search'
import './Header.scss'
import { Component, createElement, createComponent } from 'lib'
import Logo from '../Logo'
import HeaderButton from './components/HeaderButton'
import User from '../../assets/images/favicons/user.svg'
import ShoppingCart from '../../assets/images/favicons/shopping-cart.svg'

interface HeaderProps {
	logged: boolean
	onSignIn: () => void
}

class Header extends Component<HeaderProps, {}> {
	onSignIn() {
		this.props.onSignIn()
	}

	render() {
		return createElement(
			'header',
			{ key: 'header', className: 'header' },
			createComponent(Logo, { key: 'logo' }),
			createComponent(Search, { key: 'Search' }),
			createElement(
				'div',
				{
					key: 'header-buttons',
					className: 'header--buttons'
				},
				createComponent(HeaderButton, {
					key: 'header-button-sign-in',
					id: 0,
					buttonClass: `header--button-signin ${
						this.props.logged && 'header--button-signin-active'
					}`,
					icon: User,
					iconClass: 'header--button-signin-icon',
					text: this.props.logged === false ? 'Війти' : 'Війшли',

					onclick:
						this.props.logged === false ? () => this.onSignIn() : undefined
				}),
				createComponent(HeaderButton, {
					key: 'header-button-cart',
					id: 0,
					buttonClass: 'header--button-shopping-cart',
					icon: ShoppingCart,
					iconClass: 'header--button-shopping-cart-icon',
					text: 'Корзина'
				})
			)
		)
	}
}

export default Header
