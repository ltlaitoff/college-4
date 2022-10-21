import { Component } from '../../packages/reactiveLibrary/component'
import { createElement } from '../../packages/reactiveLibrary/virtual_dom'

interface RouterState {
	route: string
}

class Router extends Component<{}, {}> {
	render() {
		return createElement('main', { key: 'main' })
	}
}

export default Router
