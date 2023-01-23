import { createStore } from 'vuex'
import { countStore, themeStore } from './modules'

const store = createStore({
	modules: { count: countStore, theme: themeStore }
})

export { store }
