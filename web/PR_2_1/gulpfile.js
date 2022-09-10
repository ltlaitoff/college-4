const { src, dest, watch, parallel } = require('gulp')
const sass = require('gulp-sass')(require('sass'))
const sync = require('browser-sync').create()
const embedSvg = require('gulp-embed-svg')

function generateCSS(callback) {
	src('./src/style/style.scss')
		.pipe(sass().on('error', sass.logError))
		.pipe(dest('build/style'))

	callback()
}

function generateHTML(callback) {
	src('./src/index.html')
		.pipe(
			embedSvg({
				root: './src/assets/images/favicons/'
			})
		)
		.pipe(dest('build'))

	callback()
}

function moveFonts(callback) {
	src('./src/assets/fonts/**').pipe(dest('build/fonts'))

	callback()
}

function browserSync(callback) {
	sync.init({
		server: {
			baseDir: './build'
		}
	})

	watch('./src/style/**/*.scss', generateCSS)
	watch('./src/index.html', generateHTML)

	watch('./build/**.html').on('change', sync.reload)
	watch('./build/**/*.css').on('change', sync.reload)
}

exports.default = parallel(browserSync, moveFonts)
