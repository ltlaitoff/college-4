<script setup>
import { computed } from 'vue'

const props = defineProps(['modelValue'])
const emit = defineEmits(['update:modelValue'])

const value = computed({
	get() {
		return props.modelValue
	},
	set(value) {
		emit('update:modelValue', value)
	}
})
</script>

<template>
	<label class="font-light text-gray-800 dark:text-gray-100">
		Search:
		<input
			class="text-base ml-2 border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 rounded focus-visible:border-sky-300 focus-visible:outline-none p-1 pl-2 dark:border-gray-500 dark:bg-gray-500 dark:font-normal dark:text-gray-100"
			type="text"
			v-model="value"
		/>
	</label>
</template>
