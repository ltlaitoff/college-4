<script setup>
const NAME = 'Ivan'

function onClick() {
	console.log(`onClick: ${NAME}`)
}
function onMouseEnter() {
	console.log(`onMouseEnter: ${NAME}`)
}
function onMouseLeave() {
	console.log(`onMouseLeave: ${NAME}`)
}
</script>

<template>
	<button
		:class="$style.button"
		@click="onClick"
		@mouseenter="onMouseEnter"
		@mouseleave="onMouseLeave"
	>
		{{ NAME }}
	</button>
</template>

<style lang="scss" module src="../style/components/EventName.scss"></style>
