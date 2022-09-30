const path = require('path')

module.exports = {
	env: {
		browser: true,
		node: true,
		es2021: true
	},
	extends: ['eslint:recommended', 'plugin:import/recommended'],
	parserOptions: {
		ecmaVersion: 'latest',
		sourceType: 'module'
	},
	rules: {
		'no-console': 'off',
		indent: ['error', 'tab', { SwitchCase: 1 }],
		quotes: ['error', 'single']
	},
	settings: {
		'import/resolver': {
			alias: {
				map: [
					['assets', path.resolve(__dirname, 'src/assets/')],
					['style', path.resolve(__dirname, 'src/style/')],
					['components', path.resolve(__dirname, 'src/components/')],
					['helpers', path.resolve(__dirname, 'src/helpers/')],
					['favicons', path.resolve(__dirname, 'src/assets/images/favicons')],
					['pages', path.resolve(__dirname, 'src/pages')],
					['api', path.resolve(__dirname, 'src/api/')],
					['router', path.resolve(__dirname, 'src/router/')],
					['store', path.resolve(__dirname, 'src/store/')]
				]
			},
			extensions: ['.js', '.less', '.json', '.vue']
		}
	}
}
