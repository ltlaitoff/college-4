import dispather from './dispather'

let store = { shoppingCart: [], logged: false }
let watchers = []

export const setStore = action => {
	store = structuredClone(dispather(store, action))
	console.log(store, watchers)
	watchers.forEach(callback => callback())
}

export const getStore = () => {
	return store
}

export const addWatcher = callback => {
	watchers.push(callback)
}
