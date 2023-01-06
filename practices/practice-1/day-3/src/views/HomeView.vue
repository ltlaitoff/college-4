<script setup>
import STUDENTS from '../config/students'
import { reactive, ref } from 'vue'

const students = reactive(STUDENTS)
const filter = ref('')

const deleteItem = id => {
	const index = students.findIndex(item => item.id === id)
	students.splice(index, 1)
}
</script>

<template>
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
</template>

<style lang="scss" src="../style/views/HomeView.scss"></style>
