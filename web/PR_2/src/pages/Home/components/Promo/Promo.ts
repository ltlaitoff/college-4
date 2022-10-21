import { Component, createElement } from 'lib'
import './Promo.scss'

class Promo extends Component<{}, {}> {
	render() {
		return createElement(
			'div',
			{
				key: 'home-promo',
				className: 'promo animate__animated animate__pulse'
			},
			createElement('h2', {
				key: 'home-promo-title',
				className: 'promo--title',
				innerHTML: 'Онлайн-сервис<br />доставки їжі на дім'
			}),
			createElement('div', {
				key: 'home-promo-text',
				className: 'promo--text',
				innerHTML:
					'Страви із полюбленого ресторану привезе<br />курьер в перчатках, масці і с антисептиком'
			})
		)
	}
}

export default Promo
