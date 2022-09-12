import { createElement } from '../../helpers/createElement'
import FooterMenu from './components/FooterMenu'
import Logo from '../Logo'
import menuInfo from './data/menuInfo'
import Social from '../Social'

import './Footer.scss'

const Footer = () => {
	const footerWrapper = createElement('div', {
		className: 'footer--wrapper',
		childs: [Logo(), FooterMenu({ menuInfo })]
	})

	const footer = createElement('footer', {
		className: 'footer',
		childs: [footerWrapper, Social()]
	})

	return footer
}

/*
<footer class='footer'>
	<div class='footer--wrapper'>
		<a class='logo' href='./index.html'>
			<svg class='logo--image' src='logo.svg'></svg>

			<h1 class='logo--text'>
				Delivery
				<br />
				food
			</h1>
		</a>
		<nav class='footer--menu'>
			<ul class='footer--menu-list'>
				<li class='footer--menu-item'>
					<a class='foolter--menu-link'>Ресторанам</a>
				</li>
				<li class='footer--menu-item'>
					<a class='foolter--menu-link'>Курьерам</a>
				</li>
				<li class='footer--menu-item'>
					<a class='foolter--menu-link'>Пресс-центр</a>
				</li>
				<li class='footer--menu-item'>
					<a class='foolter--menu-link'>Контакты</a>
				</li>
			</ul>
		</nav>
	</div>

	<ul class='social'>
		<li class='social--item'>
			<a class='social--item-link'>
				<svg class='social--item-icon' src='telegram.svg'></svg>
			</a>
		</li>
		<li class='social--item'>
			<a class='social--item-link'>
				<svg class='social--item-icon' src='instagram.svg'></svg>
			</a>
		</li>
		<li class='social--item'>
			<a class='social--item-link'>
				<svg class='social--item-icon' src='facebook.svg'></svg>
			</a>
		</li>
	</ul>
</footer>
*/

export default Footer
