import LoadIcon from 'components/LoadIcon'
import { createElement } from 'helpers'
import './Search.scss'

const Search = () => {
	const icon = LoadIcon('home', 'search--icon')

	const input = createElement('input', {
		className: 'search--input',
		type: 'text',
		placeholder: 'Адреса доставки'
	})

	const search = createElement('div', {
		className: 'search',
		childs: [icon, input]
	})

	return search
}

export default Search
