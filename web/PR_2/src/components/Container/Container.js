import { createElement } from 'helpers'
import './Container.scss'

const Container = child => {
	const container = createElement('div', {
		className: 'container',
		child: child
	})

	return container
}

export default Container
