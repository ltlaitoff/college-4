const themeStore = {
	namespaced: true,
	state() {
		return {
			theme: 'dark'
		}
	},
	mutations: {
		setLightTheme(state) {
			state.theme = 'light'
		},
		setDarkTheme(state) {
			state.theme = 'dark'
		},
		toggleTheme(state) {
			if (state.theme === 'light') {
				this.commit('theme/setDarkTheme')
				return
			}

			this.commit('theme/setLightTheme')
		}
	},
	getters: {
		getTheme: state => {
			return state.theme
		}
	}
}

export { themeStore }
