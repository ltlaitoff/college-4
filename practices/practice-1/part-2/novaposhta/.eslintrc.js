module.exports = {
	root: true,
	env: {
		node: true
	},
	extends: ['plugin:vue/essential', 'eslint:recommended', 'prettier'],
	plugins: ['prettier'],
	parserOptions: {
		parser: '@babel/eslint-parser'
	},
	rules: {
		'prettier/prettier': 'error'
	}
}
