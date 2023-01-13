const styles = {
	get: 'color: #06b6d4',
	post: 'color: #49cc90',
	put: 'color: #fca130',
	delete: 'color: #f93e3e'
}

const getRequestPrint = message => {
	console.log('%c[GET]\t', styles.get, message)
}

const postRequestPrint = message => {
	console.log('%c[POST]\t', styles.post, message)
}

const putRequestPrint = message => {
	console.log('%c[PUT]\t', styles.put, message)
}

const deleteRequestPrint = message => {
	console.log('%c[DELETE]', styles.delete, message)
}

export {
	getRequestPrint,
	postRequestPrint,
	putRequestPrint,
	deleteRequestPrint
}
