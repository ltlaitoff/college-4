const path = require('path')
const webpack = require('webpack')
const { VueLoaderPlugin } = require('vue-loader')
const HtmlWebpackPlugin = require('html-webpack-plugin')

module.exports = {
	entry: './src/main.js',
	resolve: {
		alias: {
			vue: 'vue/dist/vue.esm-bundler'
		}
	},
	module: {
		rules: [
			{
				test: /\.vue$/,
				loader: 'vue-loader'
			},
			{
				test: /\.css$/,
				oneOf: [
					// this matches `<style module>`
					{
						resourceQuery: /module/,
						use: [
							'vue-style-loader',
							{
								loader: 'css-loader',
								options: {
									modules: true
								}
							},
							'postcss-loader'
						]
					},
					// this matches plain `<style>` or `<style scoped>`
					{
						use: ['vue-style-loader', 'css-loader', 'postcss-loader']
					}
				]
			}

			// {
			// 	test: /\.css$/i,
			// 	include: path.resolve(__dirname, 'src'),
			// 	use: [
			// 		'style-loader',
			// 		'vue-style-loader',
			// 		{
			// 			loader: 'css-loader',
			// 			options: {
			// 				// enable CSS Modules
			// 				modules: true
			// 			}
			// 		},
			// 		'postcss-loader'
			// 	]
			// }
		]
	},
	devServer: {
		static: path.join(__dirname, 'src'),
		compress: true,
		port: 8080
	},
	plugins: [
		new webpack.DefinePlugin({
			__VUE_OPTIONS_API__: true,
			__VUE_PROD_DEVTOOLS__: false
		}),
		new HtmlWebpackPlugin({
			template: './index.html'
		}),
		new VueLoaderPlugin()
	]
}
