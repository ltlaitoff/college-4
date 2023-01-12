<script setup>
import { reactive, ref, onMounted } from 'vue'
import { getStudents } from '../api'
import AddStudentForm from '../components/AddStudentForm.vue'
import StudentsTable from '../components/StudentsTable.vue'
import SearchStudents from '../components/SearchStudents.vue'

/*
	_id: string
	name: string
	group: string
	photo: string
	mark: number
	isDonePr: boolean
*/
const students = reactive([])
const search = ref('')

onMounted(() => {
	getStudents().then(value => {
		students.push(...value.data)
	})
})

const addStudent = info => {
	students.push(info)
}

const deleteStudent = id => {
	const index = students.findIndex(item => item._id === id)
	students.splice(index, 1)
}
</script>

<template>
	<SearchStudents v-model="search" />

	<StudentsTable
		@deleteStudent="deleteStudent"
		:search="search"
		:students="students"
	/>
	<AddStudentForm @addStudent="addStudent" />
</template>
