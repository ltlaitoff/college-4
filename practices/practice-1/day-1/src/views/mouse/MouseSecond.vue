<script setup>
import { ref } from 'vue'
const folderOpened = ref(false)

function onDoubleClick() {
	folderOpened.value = !folderOpened.value
}
</script>

<template>
	<div
		:class="[$style.block, folderOpened && $style.opened]"
		@dblclick="onDoubleClick"
	></div>
</template>

<style src="../../style/mouse/MouseSecond.scss" lang="scss" module></style>
