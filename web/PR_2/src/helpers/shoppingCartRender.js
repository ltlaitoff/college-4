import ShoppingCart from 'components/ShoppingCart'
import { createPortal } from 'helpers/portal'

export const openShoppingCart = () => {
	const cart = document.querySelector('#app>.shopping-cart')
	if (cart) return

	let onClose = () => {
		close()
	}

	const element = ShoppingCart({ onClose: onClose })
	const close = createPortal(element)
}
