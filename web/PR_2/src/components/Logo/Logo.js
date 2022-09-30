import LoadIcon from 'components/LoadIcon'
import { createElement } from 'helpers'
import './Logo.scss'

import { route } from 'router'

const Logo = () => {
	const icon = LoadIcon('logo', 'logo--image')

	const title = createElement('h1', {
		className: 'logo--text',
		innerHTML: 'Delivery<br />food'
	})

	const logo = createElement('a', {
		className: 'logo',
		href: '#',
		childs: [icon, title]
	})

	logo.onClick = () => route('/')

	return logo
}

export default Logo
