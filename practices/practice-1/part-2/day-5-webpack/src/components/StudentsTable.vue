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
	<table class="mt-1 border-collapse text-left">
		<thead :class="$style.head">
			<tr>
				<th class="py-2 px-4 text-slate-900 dark:text-slate-100 font-normal">
					Name
				</th>
				<th class="py-2 px-4 text-slate-900 dark:text-slate-100 font-normal">
					Group
				</th>
				<th class="py-2 px-4 text-slate-900 dark:text-slate-100 font-normal">
					Practice is done
				</th>
			</tr>
		</thead>
		<tbody class="border-2 border-white dark:border-gray-700">
			<tr
				:class="['text-slate-600 dark:text-slate-300', $style.row]"
				v-for="item in props.students"
				:key="item._id"
			>
				<td
					:class="[
						'border border-gray-200 py-3 px-4  transition align-middle',
						inSearch(item.name) && 'text-pink-400 font-medium'
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
						class="text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:border-sky-300 focus-visible:outline-none p-1 pl-2 dark:border-gray-500 dark:bg-gray-500 dark:font-normal dark:text-gray-100"
						type="text"
						v-model="editState.name"
					/>
				</td>
				<td class="border border-gray-200 py-3 px-4 transition align-middle">
					<span v-if="editState.id !== item._id">{{ `${item.group}` }}</span>

					<select
						v-else
						class="border-none py-2 px-4 bg-gray-100 dark:bg-gray-500 dark:text-gray-100 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:outline-none"
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
							class="bg-slate-200 dark:bg-slate-600 border-none p-2"
							value="RPZ 19 1/9"
						>
							RPZ 19 1/9
						</option>
						<option
							class="bg-slate-200 dark:bg-slate-600 border-none p-2"
							value="RPZ 19 2/9"
						>
							RPZ 19 2/9
						</option>
					</select>
				</td>
				<td
					class="border border-gray-200 py-3 px-4 transition align-middle border-r-0"
				>
					<input
						v-if="editState.id !== item._id"
						type="checkbox"
						class="w-4 h-4 checked:bg-sky-200"
						:checked="item.isDonePr"
						@click.prevent=""
					/>
					<input
						v-else
						type="checkbox"
						class="w-4 h-4 checked:bg-sky-200"
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
.rowControls {
	opacity: 0;
}

.row:hover .rowControls {
	opacity: 1;
}
</style>
