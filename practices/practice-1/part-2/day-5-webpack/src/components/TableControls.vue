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
			:class="[$style.deleteButton, $style.button]"
			@click="deleteClick"
		>
			<TrashIcon :class="$style.icon" />
		</button>

		<button
			v-if="props.editActive !== true"
			:class="[$style.editButton, $style.button]"
			@click="editClick"
		>
			<PencilIcon :class="$style.icon" />
		</button>

		<button
			v-if="props.editActive === true"
			:class="[$style.editAcceptButton, $style.button]"
			@click="emits('editAcceptClick')"
		>
			<AcceptIcon :class="$style.icon" />
		</button>
		<button
			v-if="editActive === true"
			:class="[$style.editCancelButton, $style.button]"
			@click="emits('editCancelClick')"
		>
			<CancelIcon :class="$style.icon" />
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
	@apply h-full w-8 fill-gray-400 hover:shadow-[0_0_20px_0_rgba(0,0,0,0.2)] rounded;
	transition: 0.5s all;
}

.deleteButton {
	@apply hover:border-red-400  hover:bg-red-200  hover:fill-red-600;
}

.editButton {
	@apply hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600;
}

.editAcceptButton {
	@apply border-green-400  bg-green-200  fill-green-600 hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600;
}

.editCancelButton {
	@apply border-red-400  bg-red-200  fill-red-600 hover:border-sky-400  hover:bg-sky-200  hover:fill-sky-600;
}
.icon {
	@apply w-full fill-inherit;
}
</style>
