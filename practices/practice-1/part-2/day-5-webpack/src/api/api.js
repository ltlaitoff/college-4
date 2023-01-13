import axios from 'axios'

axios.defaults.baseURL = 'http://34.82.81.113:3000'

export const getStudents = () => {
	return axios.get('/students')
}

export const addStudent = student => {
	return axios.post('/students', student)
}

export const deleteStudent = id => {
	return axios.delete(`/students/${id}`)
}

export const updateStudent = (id, student) => {
	return axios.put(`/students/${id}`, student)
}
