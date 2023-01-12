<script setup>
import { ref } from 'vue'
const blocksCount = 350

const hoverId = ref(-1)

function onMouseEnter(id) {
	hoverId.value = id
}

function onMouseLeave() {
	hoverId.value = -1
}
</script>

<template>
	<div :class="$style.wrapper">
		<div
			:class="[$style.block, hoverId === id && $style.hover]"
			v-for="id in blocksCount"
			:key="id"
			@mouseenter="onMouseEnter(id)"
			@mouseleave="onMouseLeave(id)"
		>
			{{ id }}
		</div>
	</div>
</template>

<style src="../../style/mouse/MouseThird.scss" lang="scss" module></style>
