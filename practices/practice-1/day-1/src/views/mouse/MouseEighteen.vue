<script setup>
import { ref } from 'vue'
import image from '../../assets/mouse/eighteen/img.jpg'

const allScreen = ref(false)

const onSmallClick = () => {
	allScreen.value = true
}

const onBigClick = e => {
	console.log(e)

	if (e.target.tagName !== 'IMG') {
		allScreen.value = false
		console.log('no img')
	}
}
</script>

<template>
	<div
		:class="$style.smallContainer"
		v-if="allScreen === false"
		@click="onSmallClick"
	>
		<img
			:class="[$style.image]"
			:src="image"
			alt="Small eighteen image"
		/>
	</div>

	<div
		:class="$style.bigContainer"
		v-else
		@click="onBigClick"
	>
		<div :class="$style.bg"></div>
		<img
			:class="[$style.image, $style.bigImage]"
			:src="image"
			alt="Big eighteen image"
		/>
	</div>
</template>

<style src="../../style/mouse/MouseEighteen.scss" lang="scss" module></style>
