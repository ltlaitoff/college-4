import axios from 'axios'

const BASE_API_URL = 'http://34.82.81.113:3000'

export const getStudents = () => {
	return axios.get(BASE_API_URL + '/students')
}
