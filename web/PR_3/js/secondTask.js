import { getFormatedPhone } from './getFormatedPhone.js'

const secondTask = () => {
	const second = document.createElement('form')
	const h2 = document.createElement('h2')
	h2.textContent = 'Second'

	const label = document.createElement('label')
	const input = document.createElement('input')
	input.type = 'text'

	label.textContent = 'Phone: '
	label.append(input)

	const button = document.createElement('button')
	button.textContent = 'Get'

	const result = document.createElement('div')

	second.append(h2)
	second.append(label)

	second.append(button)
	second.append(result)

	second.addEventListener('submit', e => {
		e.preventDefault()

		result.textContent = getFormatedPhone(input.value) || 'Null'
	})

	return second
}

export { secondTask }
