<script setup>
import { reactive, ref, onMounted, nextTick } from 'vue'
import { getStudents, addStudent, deleteStudent, updateStudent } from '../api'
import AddStudentForm from '../components/AddStudentForm.vue'
import StudentsTable from '../components/StudentsTable.vue'
import SearchStudents from '../components/SearchStudents.vue'

import {
	getRequestPrint,
	postRequestPrint,
	putRequestPrint,
	deleteRequestPrint
} from '../utils/coloredConsoleMessages'

/*
	_id: string
	name: string
	group: string
	photo: string
	mark: number
	isDonePr: boolean
*/
const state = reactive({ students: [] })
const search = ref('')

const getDataFromAPI = () => {
	getRequestPrint('/students')

	getStudents().then(value => {
		state.students = value.data
	})
}

onMounted(() => getDataFromAPI())

const addStudentWrapper = student => {
	postRequestPrint(`/students with data = ${JSON.stringify(student)}`)

	addStudent(student).then(() => getDataFromAPI())
}

const deleteStudentWrapper = id => {
	deleteRequestPrint(`/students/${id}`)

	deleteStudent(id).then(() => getDataFromAPI())
}

const updateStudentWrapper = (id, student) => {
	putRequestPrint(`/students/${id} with data = ${JSON.stringify(student)}`)
	updateStudent(id, student)
}
</script>

<template>
	{{ state.students }}
	<SearchStudents v-model="search" />

	<StudentsTable
		@deleteStudent="deleteStudentWrapper"
		:search="search"
		:students="state.students"
	/>
	<AddStudentForm @addStudent="addStudentWrapper" />
</template>
