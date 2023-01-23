import { createStore } from 'vuex'
import { countStore, themeStore } from './modules'
/* WARNING: vuex-persistedstate is DEPRECATED */
import createPersistedState from 'vuex-persistedstate'

const store = createStore({
	modules: { count: countStore, theme: themeStore },

	plugins: [
		/* WARNING: vuex-persistedstate is DEPRECATED */
		createPersistedState({ key: 'students-app' })
	]
})

export { store }
