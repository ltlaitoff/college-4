<script setup>
import { ref } from 'vue'

import firstFourImage from '../../assets/mouse/four/1.webp'
import secondFourImage from '../../assets/mouse/four/2.jpg'
import thirdFourImage from '../../assets/mouse/four/3.webp'
import fiveFourImage from '../../assets/mouse/four/4.jpg'

const items = [
	{ id: 0, imagePath: firstFourImage },
	{ id: 1, imagePath: secondFourImage },
	{ id: 2, imagePath: thirdFourImage },
	{ id: 3, imagePath: fiveFourImage }
]

const currentImageId = ref(-1)

function onItemClick(id) {
	currentImageId.value = id
}
</script>

<template>
	<div :class="$style.wrapper">
		<div
			:class="$style.mainImage"
			:style="`background-image: url('${
				items.find(item => item.id === currentImageId)?.imagePath || ''
			}');`"
		></div>

		<div :class="$style.choice">
			<div
				:class="$style.choiceItem"
				v-for="item in items"
				:key="item.id"
				:style="`background-image: url('${item.imagePath}');`"
				@click="onItemClick(item.id)"
			></div>
		</div>
	</div>
</template>

<style src="../../style/mouse/MouseFour.scss" lang="scss" module></style>
