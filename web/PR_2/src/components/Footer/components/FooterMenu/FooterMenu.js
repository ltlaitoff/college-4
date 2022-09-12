import { createElement } from '../../../../helpers/createElement'

const FooterMenu = ({ menuInfo }) => {
	const listItems = menuInfo.map(info => {
		return createElement('li', {
			className: 'footer--menu-item',
			child: createElement('a', {
				className: 'footer--menu-link',
				text: info.text,
				href: menuInfo.href
			})
		})
	})

	const list = createElement('ul', {
		className: 'footer--menu-list',
		childs: listItems
	})

	const nav = createElement('nav', {
		className: 'footer--menu',
		child: list
	})

	return nav
}

export default FooterMenu
