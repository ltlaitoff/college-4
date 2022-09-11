const createElement = (tag, options) => {
	const element = document.createElement(tag)

	Object.entries(options).forEach(([key, value]) => {
		if (key === 'child') {
			element.append(value)
			return
		}

		if (key === 'childs') {
			value.forEach(currentChild => {
				element.append(currentChild)
			})

			return
		}

		if (value == null) return

		element[key] = value
	})

	return element
}

export { createElement }
