<script setup>
import { ref } from 'vue'

const currentOffset = ref(0)

const onClick = () => {
	currentOffset.value += 100
}
</script>

<template>
	<div
		:class="$style.block"
		:style="`margin-top: ${currentOffset}px;`"
		@click="onClick"
	></div>
</template>

<style src="../../style/mouse/MouseFive.scss" lang="scss" module></style>
