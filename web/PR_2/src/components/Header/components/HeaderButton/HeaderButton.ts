import {
	Component,
	createElement
} from '../../../../../packages/reactiveLibrary'

interface HeaderButtonProps {
	id: number
	buttonClass: string
	icon: string
	iconClass: string
	text: string
}

interface HeaderButtonProps {
	onclick?: () => void
}

class HeaderButton extends Component<HeaderButtonProps, {}> {
	render() {
		return createElement(
			'button',
			{
				key: `headerButton-${this.props.id}`,
				className: `header--button ${this.props.buttonClass}`,
				onclick: () => {
					this.props.onclick?.()
				}
			},
			createElement('div', {
				key: `headerButtonIcon-${this.props.id}`,
				className: `header--button-icon ${this.props.iconClass}`,
				innerHTML: this.props.icon
			}),
			createElement('div', {
				key: `headerButtonText-${this.props.id}`,
				className: '',
				textContent: this.props.text
			})
		)
	}
}

// const ButtonWithIconAndText = ({
// 	buttonClass,
// 	icon,
// 	iconClasses,
// 	text,
// 	textClass = ''
// }) => {
// 	const iconElement = LoadIcon(icon, ...iconClasses)

// 	const textElement = createElement('div', {
// 		textContent: text,
// 		className: textClass
// 	})

// 	const button = createElement('button', {
// 		className: buttonClass,
// 		childs: [iconElement, textElement]
// 	})

// 	return button
// }

export default HeaderButton
