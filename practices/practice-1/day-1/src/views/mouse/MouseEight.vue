<script setup>
import mainImage from '../../assets/mouse/eight/img.jpg'

function onClick(e) {
	const target = e.target
	const { width: currentWidht, height: currentHeight } =
		target.getBoundingClientRect()

	target.style.width = `${
		currentWidht >= 800 ? currentWidht - 100 : currentWidht + 50
	}px`

	target.style.height = `${
		currentHeight >= 500 ? currentHeight - 100 : currentHeight + 50
	}px`
}
</script>

<template>
	<img
		:class="$style.image"
		:src="mainImage"
		alt="Eight image"
		@click="onClick"
	/>
</template>

<style src="../../style/mouse/MouseEight.scss" lang="scss" module></style>
