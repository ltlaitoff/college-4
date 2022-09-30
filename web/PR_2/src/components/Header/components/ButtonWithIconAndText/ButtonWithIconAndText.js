import { createElement } from 'helpers'
import LoadIcon from 'components/LoadIcon'

const ButtonWithIconAndText = ({
	buttonClass,
	icon,
	iconClasses,
	text,
	textClass = ''
}) => {
	const iconElement = LoadIcon(icon, ...iconClasses)

	const textElement = createElement('div', {
		textContent: text,
		className: textClass
	})

	const button = createElement('button', {
		className: buttonClass,
		childs: [iconElement, textElement]
	})

	return button
}

export default ButtonWithIconAndText
