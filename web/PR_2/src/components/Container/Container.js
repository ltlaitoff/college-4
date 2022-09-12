import { createElement } from '../../helpers/createElement'
import './Container.scss'

const Container = ({ childs }) => {
	const container = createElement('div', {
		className: 'container',
		childs: childs
	})

	return container
}

export default Container
