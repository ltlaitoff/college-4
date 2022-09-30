import { createElement } from 'helpers'
import Logo from 'components/Logo'

import { FooterMenu, Social } from './components'
import { menuInfo } from './data'

import './Footer.scss'

const Footer = () => {
	return createElement('footer', {
		className: 'footer',
		childs: [
			createElement('div', {
				className: 'footer--wrapper',
				childs: [Logo(), FooterMenu({ menuInfo })]
			}),
			Social()
		]
	})
}

export default Footer
