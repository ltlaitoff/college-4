function getRowWithDivider(first, second, divider) {
	if (first === '' || second === '') return null

	if (typeof divider !== 'string' && !(divider instanceof Array)) {
		return null
	}

	if (typeof divider === 'string') {
		divider = [divider]
	}

	const loweredFirst = first.toLowerCase()
	const loweredSecond = second.toLowerCase()

	let firstWithoutDividers = loweredFirst
	let secondWithoutDividers = loweredSecond

	divider.forEach(currentDivider => {
		firstWithoutDividers = firstWithoutDividers.replaceAll(currentDivider, '')
		secondWithoutDividers = secondWithoutDividers.replaceAll(currentDivider, '')
	})

	const firstDividerCount = first.length - firstWithoutDividers.length
	const secondDividerCount = second.length - secondWithoutDividers.length

	return firstDividerCount >= secondDividerCount ? first : second
}

export { getRowWithDivider }

// module.exports = {
// 	getRowWithDivider,
// }
