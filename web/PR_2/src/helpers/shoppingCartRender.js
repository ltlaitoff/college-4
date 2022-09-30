import ShoppingCart from 'components/ShoppingCart'

export const openShoppingCart = () => {
	const cart = document.querySelector('#app>.shopping-cart')
	if (cart) return

	const app = document.querySelector('#app')

	app.append(ShoppingCart())
}

export const removeShoppingCart = () => {
	const cart = document.querySelector('#app>.shopping-cart')

	if (!cart) return

	cart.remove(ShoppingCart())
}
