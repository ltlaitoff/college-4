import dispather from './dispather'

let store = { shoppingCart: [] }

export const setStore = action => {
	store = structuredClone(dispather(store, action))
}

export const getStore = () => {
	return store
}
