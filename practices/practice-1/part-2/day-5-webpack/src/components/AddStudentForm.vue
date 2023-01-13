<script setup>
import { reactive, defineEmits } from 'vue'

const emits = defineEmits({
	addStudent: null
})

const state = reactive({
	name: '',
	group: '',
	photo: '',
	mark: 0,
	isDonePr: false
})

const stateToObject = state => {
	return {
		name: state.name,
		group: state.group,
		photo: state.photo,
		mark: state.mark,
		isDonePr: state.isDonePr
	}
}

const stateToDefault = () => {
	state.name = ''
	state.group = ''
	state.photo = ''
	state.mark = ''
	state.isDonePr = ''
}

function addStudent() {
	emits('addStudent', stateToObject(state))
	stateToDefault()
}
</script>

<template>
	<form
		:class="$style.form"
		@submit.prevent="addStudent"
	>
		<label :class="$style.label">
			Name
			<input
				:class="$style.input"
				type="text"
				v-model="state.name"
			/>
		</label>

		<label :class="$style.label">
			Groups
			<select
				:class="$style.select"
				class="select"
				v-model="state.group"
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
		</label>

		<label :class="$style.label">
			Practice is done
			<input
				:class="$style.checkbox"
				v-model="state.isDonePr"
				type="checkbox"
			/>
		</label>

		<button :class="$style.addButton">Add student</button>
	</form>
</template>

<style module>
.form {
	@apply p-2 pb-5 w-96 mt-5 inline-flex flex-col items-center justify-center items-start border rounded;
}

.label {
	@apply flex items-center justify-between w-full py-3 px-4 text-slate-600 transition;
}

.input {
	@apply w-48 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:border-sky-300 focus-visible:outline-none p-1 pl-2;
}

.select {
	@apply border-none py-2 px-4 bg-gray-100 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:outline-none;
}

.selectOption {
	@apply bg-slate-200 border-none p-2;
}

.checkbox {
	@apply w-4 h-4;
}

.addButton {
	@apply mt-5 hover:border-green-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] py-2 px-4 shadow bg-zinc-100 rounded border border-zinc-200 hover:bg-green-300 transition text-zinc-600 hover:text-zinc-800;
}
</style>
