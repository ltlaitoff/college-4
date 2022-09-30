const path = require('path')
const HtmlWebpackPlugin = require('html-webpack-plugin')

module.exports = {
	entry: './src/index.js',
	output: {
		filename: 'bundle.js',
		path: path.resolve(__dirname, 'build'),
		clean: true
	},
	resolve: {
		alias: {
			assets: path.resolve(__dirname, 'src/assets/'),
			style: path.resolve(__dirname, 'src/style/'),
			components: path.resolve(__dirname, 'src/components/'),
			helpers: path.resolve(__dirname, 'src/helpers/'),
			favicons: path.resolve(__dirname, 'src/assets/images/favicons'),
			pages: path.resolve(__dirname, 'src/pages'),
			api: path.resolve(__dirname, 'src/api/'),
			router: path.resolve(__dirname, 'src/router/'),
			store: path.resolve(__dirname, 'src/store/')
		}
	},

	module: {
		rules: [
			{
				test: /\.scss$/i,
				use: ['style-loader', 'css-loader', 'sass-loader']
			},
			{
				test: /\.(png|jpg|jpeg|gif)$/i,
				type: 'asset/resource'
			},
			{
				test: /\.svg$/,
				loader: 'svg-inline-loader'
			}
		]
	},
	plugins: [
		new HtmlWebpackPlugin({
			title: 'PR_2',
			template: './public/index.html'
		})
	],
	devServer: {
		static: './build'
	}
}
