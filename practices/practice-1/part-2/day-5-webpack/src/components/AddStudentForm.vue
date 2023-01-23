<script setup>
import { reactive, defineEmits, ref } from 'vue'

const emits = defineEmits({
	addStudent: null
})

const isOpen = ref(false)

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
	isOpen.value = false
}
</script>

<template>
	<div class="relative">
		<button
			class="mt-3 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.05)] text-gray-800 dark:text-gray-100 text-base font-light border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 dark:border-gray-500 rounded focus-visible:border-sky-300 focus-visible:outline-none py-2 px-4"
			@click="isOpen = !isOpen"
		>
			{{ isOpen ? 'Close add form' : 'Open add form' }}
		</button>
		<form
			v-if="isOpen"
			:class="[
				'bg-white dark:bg-gray-600 p-2 pb-5 w-96 mt-5 inline-flex flex-col items-center justify-center border dark:border-gray-500 rounded',
				$style.form
			]"
			@submit.prevent="addStudent"
		>
			<label
				class="flex items-center justify-between w-full py-3 px-4 text-slate-600 dark:text-slate-100 transition"
			>
				Name
				<input
					class="w-48 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:border-sky-300 focus-visible:outline-none p-1 pl-2"
					type="text"
					v-model="state.name"
				/>
			</label>

			<label
				class="flex items-center justify-between w-full py-3 px-4 text-slate-600 dark:text-slate-100 transition"
			>
				Groups
				<select
					class="border-none py-2 px-4 bg-gray-100 text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:outline-none"
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
						class="bg-slate-200 border-none p-2"
						value="RPZ 19 1/9"
					>
						RPZ 19 1/9
					</option>
					<option
						class="bg-slate-200 border-none p-2"
						value="RPZ 19 2/9"
					>
						RPZ 19 2/9
					</option>
				</select>
			</label>

			<label
				class="flex items-center justify-between w-full py-3 px-4 text-slate-600 dark:text-slate-100 transition"
			>
				Practice is done
				<input
					class="w-4 h-4"
					v-model="state.isDonePr"
					type="checkbox"
				/>
			</label>

			<button
				class="mt-5 hover:border-green-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] py-2 px-4 shadow bg-zinc-100 rounded border border-zinc-200 hover:bg-green-300 transition text-zinc-600 hover:text-zinc-800"
			>
				Add student
			</button>
		</form>
	</div>
</template>

<style module>
.wrapper {
	position: relative;
}

.form {
	position: absolute;
	top: calc(35px + 0.75em);
	left: 0;

	z-index: 99;
}
</style>
