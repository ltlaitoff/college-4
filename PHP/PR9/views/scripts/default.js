const TIME_DELAY = 5000

const getDataFromAPI = () => {
	return axios.get('/index.php/students/getData')
}

const addUserToAPI = formData => {
	return axios.post('/index.php/students/addStudent', formData)
}

const actionsAPI = formData => {
	return axios.post('/index.php/students/actions', formData)
}

new Vue({
	el: '#app',

	data() {
		return {
			newItem: [],
			msg: '',
			students: [],
			groups: [],
		}
	},

	mounted() {
		this.getData()
	},

	methods: {
		getData() {
			getDataFromAPI().then(response => {
				if (response.data.students) {
					this.students = response.data.students
				}

				if (response.data.groups) {
					this.groups = response.data.groups
				}
			})
		},

		toFormData(object) {
			const formData = new FormData()

			object.forEach((element, index) => {
				formData.append(index, element)
			})

			return formData
		},

		addStudent() {
			if (!this.newItem) return

			const formData = this.toFormData(this.newItem)

			addUserToAPI(formData).then(() => {
				this.getData()
				this.newItem = []
				this.msg = 'Студент був успішно доданий'

				setTimeout(() => {
					this.msg = ''
				}, TIME_DELAY)
			})
		},

		updateStudent(student) {
			if (!student) return

			const formData = this.toFormData(student)
			formData.append('update', student.id)

			actionsAPI(formData).then(() => {
				this.getData()
				this.newItem = []
				this.msg = 'Студент був успішно змінений'

				setTimeout(() => {
					this.msg = ''
				}, TIME_DELAY)
			})
		},

		deleteStudent(student) {
			if (!student) return

			const formData = this.toFormData(student)
			formData.append('delete', student.id)

			actionsAPI(formData).then(() => {
				this.getData()
				this.newItem = []
				this.msg = 'Студент був успішно видалений'

				setTimeout(() => {
					this.msg = ''
				}, TIME_DELAY)
			})
		},
	},
})
