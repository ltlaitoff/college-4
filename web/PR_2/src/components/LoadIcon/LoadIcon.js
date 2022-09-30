import { htmlStringToElement } from 'helpers'

const LoadIcon = (path, ...className) => {
	const iconString = require(`assets/images/favicons/${path}.svg`)
	const iconElement = htmlStringToElement(iconString)

	if (className != '') {
		iconElement.classList.add(...className)
	}

	return iconElement
}

export default LoadIcon
