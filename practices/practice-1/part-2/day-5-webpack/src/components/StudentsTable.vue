<script setup>
import { ref } from 'vue'
import TableControls from './TableControls.vue'

const emit = defineEmits({
	deleteStudent: null,
	updateStudent: null
})

const editState = ref({
	id: '',
	name: '',
	group: '',
	isDonePr: false
})

const props = defineProps(['students', 'search'])

const deleteItem = id => {
	emit('deleteStudent', id)
}

const inSearch = text => {
	if (props.search === '') return false

	return text.toLowerCase().indexOf(props.search.toLowerCase()) >= 0
}

const editClick = item => {
	editState.value = {
		id: item._id,
		name: item.name,
		group: item.group,
		isDonePr: item.isDonePr
	}
}

const editAcceptClick = () => {
	const editStateValue = editState.value
	emit('updateStudent', { ...editStateValue })

	props.students.forEach((item, index) => {
		if (item._id === editStateValue.id) {
			props.students[index].name = editStateValue.name
			props.students[index].group = editStateValue.group
			props.students[index].isDonePr = editStateValue.isDonePr
		}
	})

	editState.value = {
		id: '',
		name: '',
		group: '',
		isDonePr: false
	}
}

const editCancelClick = () => {
	editState.value = {
		id: '',
		name: '',
		group: '',
		isDonePr: false
	}
}
</script>

<template>
	<table :class="$style.table">
		<thead :class="$style.head">
			<tr>
				<th :class="$style.headItem">Name</th>
				<th :class="$style.headItem">Group</th>
				<th :class="$style.headItem">Practice is done</th>
			</tr>
		</thead>
		<tbody :class="$style.body">
			<tr
				:class="$style.row"
				v-for="item in props.students"
				:key="item._id"
			>
				<td
					:class="[
						$style.bodyItem,
						inSearch(item.name) && $style.bodyItemSearch
					]"
				>
					<router-link
						:to="`/student-info/${item._id}`"
						v-if="editState.id !== item._id"
					>
						{{ `${item.name}` }}
					</router-link>
					<input
						v-else
						type="text"
						v-model="editState.name"
					/>
				</td>
				<td :class="$style.bodyItem">
					<span v-if="editState.id !== item._id">{{ `${item.group}` }}</span>

					<select
						v-else
						:class="$style.select"
						v-model="editState.group"
					>
						<option
							value=""
							selected
							disabled
							hidden
						>
							Choose group
						</option>

						<option
							:class="$style.selectOption"
							value="RPZ 19 1/9"
						>
							RPZ 19 1/9
						</option>
						<option
							:class="$style.selectOption"
							value="RPZ 19 2/9"
						>
							RPZ 19 2/9
						</option>
					</select>
				</td>
				<td :class="[$style.bodyItem, $style.lastItem]">
					<input
						v-if="editState.id !== item._id"
						type="checkbox"
						:class="$style.checkbox"
						:checked="item.isDonePr"
						@click.prevent=""
					/>
					<input
						v-else
						type="checkbox"
						:class="$style.checkbox"
						v-model="editState.isDonePr"
					/>
				</td>

				<TableControls
					@deleteClick="deleteItem(item._id)"
					@editClick="editClick(item)"
					@editAcceptClick="editAcceptClick()"
					@editCancelClick="editCancelClick()"
					:editActive="item._id === editState.id"
					:class="$style.rowControls"
				/>
			</tr>
		</tbody>
	</table>
</template>

<style scss module>
.table {
	@apply mt-5 border-collapse text-left;
}

.headItem {
	@apply py-2 px-4 text-slate-900 font-normal;
}

.row:hover .rowControls {
	opacity: 1;
}

.body {
	@apply border-2 border-white;
}
.bodyItem {
	@apply border border-gray-200 py-3 px-4 text-slate-600 transition;
	vertical-align: middle;
}

.checkbox {
	@apply w-4 h-4;
}

.checkbox:checked {
	@apply bg-sky-200;
}

.bodyItemSearch {
	@apply text-pink-400 font-medium;
}

.bodyItemInvisible {
	@apply pl-3;
	vertical-align: middle;

	opacity: 0;
}

.rowControls {
	opacity: 0;
}

.lastItem {
	@apply border-r-0;
}

.select {
	@apply border-none py-2 px-4 bg-gray-100 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:outline-none;
}

.selectOption {
	@apply bg-slate-200 border-none p-2;
}
</style>
