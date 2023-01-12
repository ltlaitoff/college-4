import { computed } from 'vue';
<script setup>
const emit = defineEmits({
	deleteStudent: null
})

const props = defineProps(['students', 'search'])

const deleteItem = id => {
	emit('deleteStudent', id)
}

const inSearch = text => {
	if (props.search === '') return false

	return text.indexOf(props.search) >= 0
}
</script>

<template>
	<table :class="$style.table">
		<thead :class="$style.head">
			<tr>
				<th :class="$style.headItem">Name</th>
				<th :class="$style.headItem">Group</th>
				<th :class="$style.headItem">Practive is done</th>
			</tr>
		</thead>
		<tbody :class="$style.body">
			<tr
				v-for="item in props.students"
				:key="item._id"
			>
				<td
					:class="[
						$style.bodyItem,
						inSearch(item.name) && $style.bodyItemSearch
					]"
				>
					{{ `${item.name}` }}
				</td>
				<td :class="$style.bodyItem">
					{{ item.group }}
				</td>
				<td :class="$style.bodyItem">
					<input
						type="checkbox"
						:class="$style.checkbox"
						v-model="item.isDonePr"
					/>
				</td>

				<button
					:class="$style.deleteButton"
					@click="deleteItem(item._id)"
				>
					Delete
				</button>
			</tr>
		</tbody>
	</table>
</template>

<style module>
.table {
	@apply mt-5 border-collapse shadow-sm;
}

.head {
	@apply bg-slate-50 dark:bg-slate-700;
}
.headItem {
	@apply border border-slate-300 font-medium py-2 px-4 text-slate-800  text-left;
}

.body {
}

.bodyItem {
	@apply border border-slate-300 py-3 px-4 text-slate-600 transition;
}

.checkbox {
	@apply w-4 h-4;
}

.bodyItemSearch {
	@apply text-pink-400 font-medium;
}

.deleteButton {
	@apply ml-3 hover:border-red-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] py-2 px-4 shadow bg-zinc-100 rounded border border-zinc-200 hover:bg-red-300 transition text-zinc-600 hover:text-zinc-800;
}
</style>
