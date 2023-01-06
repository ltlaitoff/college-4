<script setup>
import FirstExample from '../components/FirstExample.vue'
import SecondExample from '../components/SecondExample.vue'
import STUDENTS from '../config/students'

import { reactive, ref } from 'vue'

const students = reactive(STUDENTS)
const filter = ref('')

const deleteItem = id => {
	const index = students.findIndex(item => item.id === id)
	students.splice(index, 1)
}

const addStudentsState = reactive({
	surname: '',
	name: '',
	patronymic: '',
	age: 0,
	group: '1',
	dateOfBirthday: '01/01/2022',
	practiceWork: false
})

function addStudent() {
	students.push(JSON.parse(JSON.stringify(addStudentsState)))

	addStudentsState.surname = ''
	addStudentsState.name = ''
	addStudentsState.patronymic = ''
	addStudentsState.age = 0
	addStudentsState.group = '1'
	addStudentsState.dateOfBirthday = '01/01/2022'
	addStudentsState.practiceWork = false
}
</script>

<template>
	<FirstExample />
	<SecondExample />

	<input
		type="text"
		v-model="filter"
	/>

	<table class="table">
		<tr class="tableHead">
			<th class="tableHeadItem">FullName</th>
			<th class="tableHeadItem">Group</th>
			<th class="tableHeadItem">Birthday</th>
			<th class="tableHeadItem">PracticeWork</th>
		</tr>
		<tr
			class="tableContent"
			v-for="item in students"
			:key="item.id"
		>
			<td
				:class="[
					'tableContentItem',
					filter !== '' &&
						`${item.surname} ${item.name} ${item.patronymic}`.indexOf(filter) >=
							0 &&
						'tableContentItemColor'
				]"
			>
				{{ `${item.surname} ${item.name} ${item.patronymic}` }}
			</td>
			<td class="tableContentItem">
				{{ item.group }}
			</td>
			<td class="tableContentItem">
				{{ item.dateOfBirthday }}
			</td>
			<td class="tableContentItem">
				<input
					type="checkbox"
					v-model="item.practiceWork"
				/>
			</td>

			<button @click="deleteItem(item.id)">Delete</button>
		</tr>
	</table>

	<form
		class="addStudent"
		@submit.prevent="addStudent"
	>
		<label class="addStudentLabel">
			Surname
			<input
				type="text"
				v-model="addStudentsState.surname"
			/>
		</label>

		<label class="addStudentLabel">
			Name
			<input
				type="text"
				v-model="addStudentsState.name"
			/>
		</label>

		<label class="addStudentLabel">
			Patronymic
			<input
				type="text"
				v-model="addStudentsState.patronymic"
			/>
		</label>

		<label class="addStudentLabel">
			Group
			<select
				class="select"
				v-model="addStudentsState.group"
			>
				<option value="1">1</option>
				<option value="2">2</option>
			</select>
		</label>

		<label class="addStudentLabel">
			DateOfBirthday
			<input
				type="dateOfBirthday"
				v-model="addStudentsState.dateOfBirthday"
			/>
		</label>

		<label class="addStudentLabel">
			PracticeWork
			<input
				v-model="addStudentsState.practiceWork"
				type="checkbox"
			/>
		</label>

		<button class="addStudentButton">Add</button>
	</form>
</template>

<style lang="scss" src="../style/views/HomeView.scss"></style>
