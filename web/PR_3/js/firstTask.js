import { getRowWithDivider } from './getRow.js'

const createInput = (text, key) => {
	const label = document.createElement('label')
	const input = document.createElement('input')
	input.type = 'text'

	label.textContent = text
	label.append(input)

	return [label, () => input]
}

const firstTask = () => {
	const first = document.createElement('form')
	const h2 = document.createElement('h2')
	h2.textContent = 'First'

	const [labelFirstString, getFirstInputTarget] = createInput('First string:', 'first')
	const [labelSecondString, getSecondInputTarget] = createInput('Second string:', 'second')
	const [labelDividersString, getDividersInputTarget] = createInput(
		"Dividers(',') string:",
		'dividers'
	)

	const button = document.createElement('button')
	button.textContent = 'Get'

	const result = document.createElement('div')

	first.append(h2)
	first.append(labelFirstString)
	first.append(labelSecondString)
	first.append(labelDividersString)
	first.append(button)
	first.append(result)

	first.addEventListener('submit', e => {
		e.preventDefault()

		const firstValue = getFirstInputTarget().value
		const secondValue = getSecondInputTarget().value
		const dividersValue = getDividersInputTarget().value.split(',')

		result.textContent = getRowWithDivider(firstValue, secondValue, dividersValue)
	})

	return first
}

export { firstTask }
