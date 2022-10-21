import { Component, createElement, createText } from 'lib'
import './LoginModal.scss'
import Cross from '../../assets/images/favicons/cross.svg'
import { createComponent } from '../../../packages/reactiveLibrary/virtual_dom'
import LoginModalButton from './LoginModalButton'

const KEY = 'login-modal'

interface LoginModalProps {
	onClose: () => void
	onSubmit: ({ login, password }: { login: string; password: string }) => void
}

class LoginModal extends Component<LoginModalProps, {}> {
	loginText = ''
	loginError = false
	passwordText = ''
	passwordError = false

	currentTargetType = ''

	onPasswordError(error: boolean) {
		this.setState(state => ({
			...state,
			passwordError: error
		}))
	}

	onLoginChange(text: string, error: boolean) {
		this.loginText = text
		this.loginError = error
	}

	onPasswordChange(text: string, error: boolean) {
		this.passwordText = text
		this.passwordError = error
	}

	closeModal() {
		this.props.onClose()
	}

	submitModal(e: Event) {
		e.preventDefault()

		if (this.loginText === '' || this.passwordText === '') {
			alert('Заповніть всі поля')
			return
		}

		this.props.onSubmit({
			login: this.loginText,
			password: this.passwordText
		})
	}

	onOutsideClick(e: Event) {
		if ((e.target as HTMLDivElement).className === `${KEY}-all`) {
			this.props.onClose()
		}
	}

	public componentDidMount(): void {
		document.body.classList.add('stop-scrolling')
		const x = window.scrollX
		const y = window.scrollY
		window.addEventListener('touchmove', e => e.preventDefault(), {
			passive: false
		})
		// window.addEventListener('scroll', () => {
		// 	window.scrollTo(x, y)
		// })
	}

	public componentWillUnmount(): void {
		document.body.classList.remove('stop-scrolling')
	}

	render() {
		return createElement(
			'div',
			{
				key: `${KEY}`
			},
			createElement(
				'div',
				{
					key: `${KEY}-all`,
					className: `${KEY}-all`,
					onclick: (e: Event) => this.onOutsideClick(e)
				},
				createElement(
					'div',
					{
						key: `${KEY}-body`,
						className: `${KEY}-body`
					},
					createElement('button', {
						key: `${KEY}-close`,
						className: `${KEY}-close`,
						innerHTML: Cross,
						onclick: () => this.closeModal()
					}),

					createElement(
						'form',
						{
							key: `${KEY}-form`,
							className: `${KEY}-form`,
							onsubmit: (e: Event) => this.submitModal(e)
						},
						createElement(
							'h2',
							{
								key: `${KEY}-form-title`,
								className: `${KEY}-form-title`
							},
							createText('Authorization')
						),
						createElement(
							'label',
							{
								key: `${KEY}-form-label`,
								className: `${KEY}-form-label`
							},
							createText('Login'),
							createComponent(LoginModalButton, {
								KEY: KEY,
								key: 'login-login-buton',
								type: 'text',
								name: 'login',
								value: this.loginText,
								error: this.loginError,

								onChange: (text: string, error: boolean) =>
									this.onLoginChange(text, error)
							})
						),
						createElement(
							'label',
							{
								key: `${KEY}-form-label`,
								className: `${KEY}-form-label`
							},
							createText('Password'),
							createComponent(LoginModalButton, {
								KEY: `${KEY}`,
								key: 'login-password-buton',
								type: 'password',
								name: 'password',
								value: this.passwordText,
								error: this.passwordError,

								onChange: (text: string, error: boolean) =>
									this.onPasswordChange(text, error)
							})
						),
						createElement(
							'button',
							{
								key: `${KEY}-form-button`,
								className: `${KEY}-form-button`
							},
							createText('Submit')
						)
					)
				)
			)
		)
	}
}

export default LoginModal
