import { createElement } from '../../helpers/createElement'

const ButtonWithIconAndText = ({
	buttonClass,
	iconClass,
	iconSrc,
	iconAlt = '',
	text,
	textClass = ''
}) => {
	const icon = createElement('img', {
		className: iconClass,
		src: iconSrc
	})

	const textElement = createElement('div', {
		textContent: text,
		className: textClass
	})

	const button = createElement('button', {
		className: buttonClass,
		childs: [icon, textElement]
	})

	return button
}

export default ButtonWithIconAndText
