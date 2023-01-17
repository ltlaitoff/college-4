import axios from 'axios'
const API_KEY = process.env.API_KEY

axios.defaults.baseURL = 'https://api.novaposhta.ua/v2.0/json/'

export const findCity = cityName => {
	const data = {
		apiKey: API_KEY,
		modelName: 'Address',
		calledMethod: 'getSettlements',
		methodProperties: {
			FindByString: cityName,
			Page: '1',
			Warehouse: '1',
			Limit: 5
		}
	}

	return axios.post('', data)
}

export const getDepatmentsByCity = cityRef => {
	console.log('%capi.js line:23 cityRef', 'color: #007acc;', cityRef)
	const data = {
		apiKey: API_KEY,
		modelName: 'Address',
		calledMethod: 'getWarehouses',
		methodProperties: {
			SettlementRef: cityRef
		}
	}

	return axios.post('', data)
}

// export const testRequestToAPI = () => {
//   return axios.post('https://api.novaposhta.ua/v2.0/json/', {
//     apiKey: '6518852d88f059a3f08dac0d9708b45a',
//     modelName: 'Address',
//     calledMethod: 'getWarehouses',
//     methodProperties: {},
//   });
// };
