import { Component, createElement } from 'lib'

interface LoginModalButtonProps {
	KEY: string
	type: string
	value: string
	name: string
	error: boolean
	onChange: (text: string, error: boolean) => void
}

interface LoginModalButtonState {
	text: string
	error: boolean
}

class LoginModalButton extends Component<
	LoginModalButtonProps,
	LoginModalButtonState
> {
	state: LoginModalButtonState = { text: '', error: false }

	public componentDidMount(): void {
		this.setState(state => ({
			...state,
			text: this.props.value,
			error: this.props.error
		}))
	}

	onChange(e: InputEvent) {
		const text = (e.target as HTMLInputElement).value
		const error = text.length === 0

		// if (this.state.error !== error) {
		// this.props.onChange(text, error)
		// }
		this.props.onChange(text, error)

		this.setState(() => ({
			text: text,
			error: error
		}))
	}

	onBlur() {
		this.props.onChange(this.state.text, this.state.error)
	}

	onKeyDown(e: KeyboardEvent) {
		if (e.code === 'enter') {
			this.props.onChange(this.state.text, this.state.error)
		}
	}

	render() {
		return createElement('input', {
			key: `${this.props.KEY}-form-input`,
			type: this.props.type,
			className: `${this.props.KEY}-form-input ${
				this.state.error ? `${this.props.KEY}-form-input-error` : ''
			}`,
			name: this.props.name,
			value: this.state.text,
			oninput: (e: InputEvent) => this.onChange(e),
			onblur: () => this.onBlur(),
			onkeydown: (e: KeyboardEvent) => this.onKeyDown(e)
		})
	}
}

export default LoginModalButton
