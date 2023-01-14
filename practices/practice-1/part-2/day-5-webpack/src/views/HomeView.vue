<script setup>
import { reactive, ref, onMounted, nextTick } from 'vue'
import { getStudents, addStudent, deleteStudent, updateStudent } from '../api'
import AddStudentForm from '../components/AddStudentForm.vue'
import StudentsTable from '../components/StudentsTable.vue'
import SearchStudents from '../components/SearchStudents.vue'
import UpdateButton from '../components/UpdateButton.vue'

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
const loadStatus = ref('error')

const getDataFromAPI = () => {
	getRequestPrint('/students')

	loadStatus.value = 'updating'
	getStudents()
		.then(value => {
			state.students = value.data
			loadStatus.value = 'updated'
		})
		.catch(() => {
			loadStatus.value = 'error'
		})
}

onMounted(() => getDataFromAPI())

const addStudentWrapper = student => {
	postRequestPrint(`/students with data = ${JSON.stringify(student)}`)

	addStudent(student).then(() => getDataFromAPI())
}

const deleteStudentWrapper = id => {
	deleteRequestPrint(
		`/students/${id} whehe user = ${JSON.stringify(
			state.students.find(item => item._id === id)
		)}`
	)

	deleteStudent(id).then(() => getDataFromAPI())
}

const updateStudentWrapper = student => {
	putRequestPrint(
		`/students/${student.id} with data = ${JSON.stringify(student)}`
	)
	updateStudent(student.id, student)
}
</script>

<template>
	<SearchStudents v-model="search" />
	<div class="flex gap-3">
		<UpdateButton
			:status="loadStatus"
			@click="getDataFromAPI"
		/>
		<AddStudentForm @addStudent="addStudentWrapper" />
	</div>

	<StudentsTable
		@deleteStudent="deleteStudentWrapper"
		@updateStudent="updateStudentWrapper"
		:search="search"
		:students="state.students"
	/>
</template>
