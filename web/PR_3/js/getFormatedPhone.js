const CODE = '+38'
const KEY = '#'
const MASK = `${CODE} (${KEY}${KEY}${KEY}) ${KEY}${KEY}${KEY}-${KEY}${KEY}-${KEY}${KEY}`

const getFormatedPhone = phone => {
	if (phone.length < 9) return null

	let phoneWithoutCountry = phone.replace(CODE, '')

	if (phoneWithoutCountry.length === 9) {
		phoneWithoutCountry = '0' + phoneWithoutCountry
	}

	if (phoneWithoutCountry.length < 10) return null

	const arrayedPhone = phoneWithoutCountry.split('').slice(-10)

	let result = MASK

	arrayedPhone.forEach(element => {
		result = result.replace(KEY, element)
	})

	return result
}

// +38 (095) 740-94-51

export { getFormatedPhone }
