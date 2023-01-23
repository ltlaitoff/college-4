<script setup>
import { watch, ref } from 'vue'
import TrashIcon from '../assets/table/trash.svg'
import PencilIcon from '../assets/table/pencil.svg'
import AcceptIcon from '../assets/updating/ok.svg'
import CancelIcon from '../assets/updating/error.svg'

const props = defineProps(['editActive'])
const emits = defineEmits([
	'deleteClick',
	'editClick',
	'editAcceptClick',
	'editCancelClick'
])

const deleteClick = () => {
	emits('deleteClick')
}

const editClick = () => {
	emits('editClick')
}
</script>

<template>
	<div :class="[$style.buttons, { [$style.alwaysShow]: props.editActive }]">
		<button
			v-if="props.editActive !== true"
			:class="[
				'hover:border-red-400  hover:bg-red-200  hover:fill-red-600 dark:hover:bg-red-400 dark:hover:fill-red-700',
				$style.button,
				'h-full w-8 fill-gray-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] rounded'
			]"
			@click="deleteClick"
		>
			<TrashIcon class="w-full fill-inherit" />
		</button>

		<button
			v-if="props.editActive !== true"
			:class="[
				'hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600 dark:hover:bg-sky-400 dark:hover:fill-sky-700',
				$style.button,
				'h-full w-8 fill-gray-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] rounded'
			]"
			@click="editClick"
		>
			<PencilIcon class="w-full fill-inherit" />
		</button>

		<button
			v-if="props.editActive === true"
			:class="[
				'border-green-400  bg-green-200  fill-green-600 dark:bg-green-300 dark:fill-green-600 hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600 dark:hover:border-sky-400  dark:hover:bg-sky-400  dark:hover:fill-sky-700',
				$style.button,
				'h-full w-8 fill-gray-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] rounded'
			]"
			@click="emits('editAcceptClick')"
		>
			<AcceptIcon class="w-full fill-inherit" />
		</button>
		<button
			v-if="editActive === true"
			:class="[
				'border-red-400  bg-red-200  fill-red-600 dark:bg-red-300 dark:fill-red-600 hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600 dark:hover:border-sky-400  dark:hover:bg-sky-400  dark:hover:fill-sky-700',
				$style.button,
				'h-full w-8 fill-gray-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] rounded'
			]"
			@click="emits('editCancelClick')"
		>
			<CancelIcon class="w-full fill-inherit" />
		</button>
	</div>
</template>

<style module>
.alwaysShow {
	opacity: 1 !important;
}
.buttons {
	transition: opacity 0.1s ease-in, opacity 0.4s ease-out;
	opacity: 0;
	display: flex;

	margin-left: 10px;
	column-gap: 10px;
}

.button {
	transition: 0.5s all;
}
</style>
