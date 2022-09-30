import { createElement } from 'helpers'
import './Promo.scss'

const Promo = () => {
	const title = createElement('h2', {
		className: 'promo--title',
		innerHTML: 'Онлайн-сервис<br />доставки їжі на дім'
	})

	const text = createElement('div', {
		className: 'promo--text',
		innerHTML:
			'Страви із полюбленого ресторану привезе<br />курьер в перчатках, масці і с антисептиком'
	})

	const promo = createElement('div', {
		className: 'promo animate__animated animate__pulse',
		childs: [title, text]
	})

	return promo
}

export default Promo
