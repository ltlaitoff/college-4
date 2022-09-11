import HomeIcon from '../../assets/images/favicons/home.svg'
import { createElement } from '../../helpers/createElement'
import './Search.scss'

const Search = () => {
	const icon = createElement('img', {
		className: 'search--icon',
		src: HomeIcon,
		alt: 'home icon'
	})

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
