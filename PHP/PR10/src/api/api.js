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
  return axios.post(`${BASE_URL}/index.php/subjects/addSubject`, formData)
}

export const updateSubject = (formData) => {
  return axios.post(`${BASE_URL}/index.php/subjects/actions`, formData)
}

export const deleteSubject = (formData) => {
  return axios.post(`${BASE_URL}/index.php/subjects/actions`, formData)
}

/* Uspishnist */
export const getUspishnist = () => {
  return axios.get(`${BASE_URL}/index.php/uspishnist/getUspishnist`)
}

export const addUspishnist = (formData) => {
  return axios.post(`${BASE_URL}/index.php/uspishnist/addUspishnist`, formData)
}

export const updateUspishnist = (formData) => {
  return axios.post(`${BASE_URL}/index.php/uspishnist/actions`, formData)
}

export const deleteUspishnist = (formData) => {
  return axios.post(`${BASE_URL}/index.php/uspishnist/actions`, formData)
}
