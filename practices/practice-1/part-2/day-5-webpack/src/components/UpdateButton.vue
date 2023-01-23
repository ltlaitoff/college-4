<script setup>
import ErrorIcon from '../assets/updating/error.svg'
import SpinnerIcon from '../assets/updating/spinner.svg'
import OkIcon from '../assets/updating/ok.svg'

const props = defineProps(['status'])
const emits = defineEmits(['click'])

const images = {
	unloaded: ErrorIcon,
	updating: SpinnerIcon,
	updated: OkIcon,
	error: ErrorIcon
}
</script>

<template>
	<button
		@click="emits('click')"
		:class="[
			'capitalize mt-3 fill-gray-400 flex text-gray-800 dark:text-gray-200 gap-2 text-base font-light  border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 dark:border-gray-500 rounded focus-visible:border-sky-300 focus-visible:outline-none py-2 px-4',
			{
				'text-green-900 fill-green-700 dark:!text-green-400 dark:!fill-green-500':
					props.status === 'updated',
				'text-red-900 fill-red-700 dark:!text-red-400 dark:!fill-red-500':
					props.status === 'error'
			}
		]"
	>
		<component
			:is="images[props.status]"
			preserveAspectRatio="xMidYMid meet"
			class="fill-inherit max-w-[24px] max-h-[24px] w-full h-full"
		/>
		{{ props.status }}
	</button>
</template>
