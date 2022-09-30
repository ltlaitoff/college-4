const HOME_PAGE = import(/* webpackChunkName: "homePage" */ 'pages/Home')
const RESTAURANT_PAGE = import(
	/* webpackChunkName: "restaurantPage" */ 'pages/Restaurant'
)

const ERROR_PAGE = import(/* webpackChunkName: "ErrorPage" */ 'pages/ErrorPage')

let CACHE_ROOT = null

const ROUTES = [
	{
		path: '/',
		template: HOME_PAGE
	},
	{
		path: '/restaurant',
		template: RESTAURANT_PAGE
	},
	{
		path: '*',
		template: ERROR_PAGE
	}
]

const checkPathOnErrors = (path, error = true) => {
	if (!getRoutesPathList().includes(path)) {
		if (error) {
			throw new Error('Undefined path')
		}

		return true
	}

	return false
}

const getRoutesPathList = () => {
	return ROUTES.map(route => route.path)
}

const getRoutesTemplageByPath = path => {
	path = path.split('&')[0]

	if (checkPathOnErrors(path, false)) {
		path = '*'
	}

	return ROUTES.filter(route => {
		if (route.path === path) return route
	})[0].template
}

const route = (path, params = []) => {
	checkPathOnErrors(path)

	console.log(params)

	const searchParams = new URLSearchParams('')

	params.forEach(item => {
		const [key, value] = Object.entries(item)[0]

		searchParams.append(key, value)
	})

	window.location.hash = path + '&' + searchParams.toString()
}

function router(root) {
	if (CACHE_ROOT !== root) {
		CACHE_ROOT = root
	}

	const hash = '/' + window.location.hash.replace('#/', '')
	const page = getRoutesTemplageByPath(hash)

	const paramsStr = hash.split('&')[1]
	const searchParams = new URLSearchParams(paramsStr)

	page.then(data => {
		root.replaceChildren(data.default(searchParams))
	})
}

window.onhashchange = () => router(CACHE_ROOT)
window.location.hash = ''

export { route, router }
