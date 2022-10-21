const createPortal = element => {
	const app = document.querySelector('#app')

	console.log('append', element)
	app.append(element)

	return () => {
		console.log('remove', element)

		element.remove()
	}
}

export { createPortal }
