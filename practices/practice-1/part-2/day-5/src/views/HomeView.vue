<script setup>
import { getStudents } from '../api/api'

import { reactive, ref, onMounted } from 'vue'

const students = reactive([])
const filter = ref('')

onMounted(() => {
	getStudents().then(value => {
		students.push(...value.data)
	})
})

const deleteItem = id => {
	const index = students.findIndex(item => item._id === id)
	students.splice(index, 1)
}

const addStudentsState = reactive({
	name: '',
	age: 0,
	group: '1',
	dateOfBirthday: '01/01/2022',
	isDonePr: false
})

function addStudent() {
	students.push(JSON.parse(JSON.stringify(addStudentsState)))

	addStudentsState.name = ''
	addStudentsState.age = 0
	addStudentsState.group = '1'
	addStudentsState.dateOfBirthday = '01/01/2022'
	addStudentsState.isDonePr = false
}
</script>

<template>
	<input
		type="text"
		v-model="filter"
	/>

	<table class="table">
		<tr class="tableHead">
			<th class="tableHeadItem">Name</th>
			<th class="tableHeadItem">Group</th>
			<th class="tableHeadItem">Birthday</th>
			<th class="tableHeadItem">Practive is done</th>
		</tr>
		<tr
			class="tableContent"
			v-for="item in students"
			:key="item._id"
		>
			<td
				:class="[
					'tableContentItem',
					filter !== '' &&
						`${item.name}`.indexOf(filter) >= 0 &&
						'tableContentItemColor'
				]"
			>
				{{ `${item.name}` }}
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
					v-model="item.isDonePr"
				/>
			</td>

			<button @click="deleteItem(item._id)">Delete</button>
		</tr>
	</table>

	<form
		class="addStudent"
		@submit.prevent="addStudent"
	>
		<label class="addStudentLabel">
			Name
			<input
				type="text"
				v-model="addStudentsState.name"
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
			Practive is done
			<input
				v-model="addStudentsState.isDonePr"
				type="checkbox"
			/>
		</label>

		<button class="addStudentButton">Add</button>
	</form>
</template>

<style lang="scss" src="../style/views/HomeView.scss"></style>
