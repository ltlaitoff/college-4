import Header from 'components/Header'
import Footer from 'components/Footer'

import { createElement } from 'helpers'
import { router } from './router'
import './style/style.scss'

const app = document.querySelector('#app')

const main = createElement('main', {
	className: 'main'
})

const modal = createElement('div', {
	id: 'modal'
})

app.append(Header())
app.append(main)
app.append(Footer())
app.append(modal)

router(main)
