<script setup>
const props = defineProps({
	count: {
		type: Number,
		required: true
	}
})
/* */
</script>

<template>
	<div class="mt-2 p-2 text-gray-600">
		Count:
		<span
			class="bg-clip-text font-medium text-transparent bg-gradient-to-r from-pink-600 to-red-700"
		>
			{{ props.count }}
		</span>
	</div>
</template>
