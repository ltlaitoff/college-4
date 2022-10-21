export const ADD_CARD_TO_STORE = 'ADD_CARD_TO_STORE'
export const REMOVE_CARD_FROM_STORE = 'REMOVE_CARD_FROM_STORE'
export const CHANGE_CARD_PRICE = 'CHANGE_CARD_PRICE'

export const SET_LOGGED_VALUE = 'SET_LOGGED_VALUE'

export const setLoggedValue = value => {
	return {
		type: SET_LOGGED_VALUE,
		payload: value
	}
}

export const addCardToStore = cart => {
	return {
		type: ADD_CARD_TO_STORE,
		payload: cart
	}
}

export const removeCardFromStore = cart => {
	return {
		type: REMOVE_CARD_FROM_STORE,
		payload: cart
	}
}

export const changeCardPrice = cart => {
	return {
		type: CHANGE_CARD_PRICE,
		payload: cart
	}
}
