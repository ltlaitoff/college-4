const loadAPIImagesRestaurants = apiData => {
	return apiData.map(element => {
		console.log(element)
		return {
			...element,
			image: require(`assets/images/restaurants/${element.image}`)
		}
	})
}

export { loadAPIImagesRestaurants }
