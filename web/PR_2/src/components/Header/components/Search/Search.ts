import './Search.scss'
import { Component, createElement } from 'lib'
import HomeIcon from '../../../../assets/images/favicons/home.svg'

class Search extends Component<{}, {}> {
	render() {
		return createElement(
			'div',
			{
				key: 'search',
				className: 'search'
			},

			createElement('div', {
				key: 'search--icon',
				className: 'search--icon',
				innerHTML: HomeIcon
			}),
			createElement('input', {
				key: 'search--input',
				className: 'search--input',
				type: 'text',
				placeholder: 'Адреса доставки'
			})
		)
	}
}

export default Search
