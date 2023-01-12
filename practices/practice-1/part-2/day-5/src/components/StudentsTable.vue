<script setup>
const emit = defineEmits({
	deleteStudent: null
})

const props = defineProps(['students', 'search'])

const deleteItem = id => {
	emit('deleteStudent', id)
}
</script>

<template>
	<table class="table">
		<tr class="tableHead">
			<th class="tableHeadItem">Name</th>
			<th class="tableHeadItem">Group</th>
			<th class="tableHeadItem">Birthday</th>
			<th class="tableHeadItem">Practive is done</th>
		</tr>
		<tr
			class="tableContent"
			v-for="item in props.students"
			:key="item._id"
		>
			<td
				:class="[
					'tableContentItem',
					props.search !== '' &&
						`${item.name}`.indexOf(props.search) >= 0 &&
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
</template>

<style lang="scss" scoped></style>
