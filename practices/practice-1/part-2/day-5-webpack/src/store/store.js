import { createStore } from 'vuex'
import { countStore } from './modules'

const store = createStore({
	modules: { count: countStore }
})

export { store }
