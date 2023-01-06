<script setup>
import { ref } from 'vue'

import firstImage from '../../assets/mouse/sixteen/1.jpg'
import secondImage from '../../assets/mouse/sixteen/2.jpg'

const currentImage = ref(1)

function onMouseEnter() {
	currentImage.value = 2
}

function onMouseLeave() {
	currentImage.value = 1
}
</script>

<template>
	<div
		:class="$style.container"
		@mouseenter="onMouseEnter"
		@mouseleave="onMouseLeave"
	>
		<img
			:class="[
				$style.image,
				$style.firstImage,
				currentImage === 1 && $style.hidden
			]"
			:src="firstImage"
			alt="Sexteen image first"
		/>
		<img
			:class="[$style.image, $style.secondImage]"
			:src="secondImage"
			alt="Sexteen image second"
		/>
	</div>

	<div :class="$style.code">
		Додайте в html код зображення: {{ `
		<img
			class="${$style.image}, ${$style.firstImage}, ${currentImage === 1 && $style.hidden}"
			src="${firstImage}"
			alt="Sexteen image first"
		/>
		<img
			class="${$style.image}, ${$style.secondImage}"
			src="${secondImage}"
			alt="Sexteen image second"
		/>
		` }}
	</div>
</template>

<style src="../../style/mouse/MouseSixteen.scss" lang="scss" module></style>
