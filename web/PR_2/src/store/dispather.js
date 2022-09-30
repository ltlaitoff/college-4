import {
	ADD_CARD_TO_STORE,
	REMOVE_CARD_FROM_STORE,
	CHANGE_CARD_PRICE
} from './actions'

export default (store = {}, action) => {
	switch (action.type) {
		case ADD_CARD_TO_STORE: {
			store.shoppingCart.push(action.payload)

			return { ...store, shoppingCart: store.shoppingCart }
		}

		case REMOVE_CARD_FROM_STORE: {
			const shoppingCart = store.shoppingCart.filter(
				element => element.id === action.payload.id
			)

			return { ...store, shoppingCart: shoppingCart }
		}

		case CHANGE_CARD_PRICE: {
			const shoppingCart = store.shoppingCart.map(element => {
				if (element.id === action.payload.id) {
					return { ...element, price: action.payload.price }
				}

				return element
			})

			return { ...store, shoppingCart: shoppingCart }
		}
	}

	return store
}
