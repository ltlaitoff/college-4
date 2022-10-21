/* eslint-disable @typescript-eslint/no-var-requires */
const path = require('path')

module.exports = {
	env: {
		browser: true,
		node: true,
		es2021: true
	},
	parser: '@typescript-eslint/parser',
	plugins: ['@typescript-eslint'],

	extends: [
		'eslint:recommended',
		'plugin:import/typescript',
		'plugin:@typescript-eslint/eslint-recommended',
		'plugin:@typescript-eslint/recommended'
	],
	parserOptions: {
		ecmaVersion: 'latest',
		sourceType: 'module'
	},

	rules: {
		'no-console': 'off',
		indent: ['error', 'tab', { SwitchCase: 1 }],
		quotes: ['error', 'single'],
		'@typescript-eslint/ban-types': [
			'error',
			{
				extendDefaults: true,
				types: {
					'{}': false
				}
			}
		]
	},
	settings: {
		'import/extensions': ['.js', '.jsx', '.ts', '.tsx'],
		'import/resolver': {
			typescript: {
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
						['store', path.resolve(__dirname, 'src/store/')],
						['lib', path.resolve(__dirname, 'packages/reactiveLibrary/')]
					]
				},
				node: {
					extensions: ['.ts']
				}
			}
		}
	}
}
