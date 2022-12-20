import axios from 'axios'

const BASE_URL = 'http://pr9'

export const getDataFromAPI = () => {
  return axios.get(`${BASE_URL}/index.php/students/getData`)
}

export const addUserToAPI = (formData) => {
  return axios.post(`${BASE_URL}/index.php/students/addStudent`, formData)
}

export const actionsAPI = (formData) => {
  return axios.post(`${BASE_URL}/index.php/students/actions`, formData)
}

/* Subjects */
export const getSubjects = () => {
  return axios.get(`${BASE_URL}/index.php/subjects/getSubjects`)
}

export const addSubject = (formData) => {
  console.log(
    [...formData.entries()] // expand the elements from the .entries() iterator into an actual array
      .map((e) => encodeURIComponent(e[0]) + '=' + encodeURIComponent(e[1]))
  )

  return axios.post(`${BASE_URL}/index.php/subjects/addSubject`, formData)
}

export const updateSubject = (formData) => {
  return axios.post(`${BASE_URL}/index.php/subjects/actions`, formData)
}

export const deleteSubject = (formData) => {
  return axios.post(`${BASE_URL}/index.php/subjects/actions`, formData)
}
