<script setup>
import { ref } from 'vue'
const currentTagName = ref('NONE')
const currentActiveId = ref(-1)

const onClick = (e, id) => {
	currentTagName.value = e.target.tagName
	currentActiveId.value = id
}
</script>

<template>
	<div :class="$style.current">{{ currentTagName }}</div>
	<div :class="$style.wrapper">
		<div
			:class="[$style.item, currentActiveId === 0 && $style.active]"
			@click="e => onClick(e, 0)"
		>
			div
		</div>
		<p
			:class="[$style.item, currentActiveId === 1 && $style.active]"
			@click="e => onClick(e, 1)"
		>
			p
		</p>
		<button
			:class="[$style.item, currentActiveId === 2 && $style.active]"
			@click="e => onClick(e, 2)"
		>
			button
		</button>
		<a
			:class="[$style.item, currentActiveId === 3 && $style.active]"
			@click="e => onClick(e, 3)"
		>
			a
		</a>
	</div>
</template>

<style src="../../style/mouse/MouseSeven.scss" lang="scss" module></style>
