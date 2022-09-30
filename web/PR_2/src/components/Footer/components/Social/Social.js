import { createElement } from 'helpers'
import './Social.scss'
import { socialData } from './data'

const Social = () => {
	const listItems = socialData.map(info => {
		info.icon.classList.add('social--item-icon')

		const link = createElement('a', {
			className: 'social--item-link',
			href: info.href,
			child: info.icon
		})

		const item = createElement('li', {
			className: 'social--item',
			child: link
		})

		return item
	})

	const social = createElement('ul', {
		className: 'social',
		childs: listItems
	})

	return social
}

export default Social
