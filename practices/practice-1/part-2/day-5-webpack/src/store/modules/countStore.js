const countStore = {
	namespaced: true,
	state() {
		return {
			count: 0
		}
	},
	mutations: {
		setCount: (state, count) => {
			state.count = count
		}
	},
	getters: {
		getCount: state => {
			return state.count
		}
	}
}

export { countStore }
