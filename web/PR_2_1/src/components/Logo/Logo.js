import LogoIcon from '../../assets/images/favicons/logo.svg'
import { createElement } from '../../helpers/createElement'
import './Logo.scss'

const Logo = () => {
	const icon = createElement('img', {
		className: 'logo--image',
		src: LogoIcon,
		alt: 'logo'
	})

	const title = createElement('h1', {
		className: 'logo--text',
		innerHTML: 'Delivery<br />food'
	})

	const logo = createElement('a', {
		className: 'logo',
		href: '#',
		childs: [icon, title]
	})

	return logo
}

export default Logo
