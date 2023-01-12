<script setup>
import { ref } from 'vue'

const age = ref(0)
const messageLazy = ref('')
const messageTrim = ref('')

/* */
</script>

<template>
	<div class="title">Example 1</div>

	<div class="container">
		<div class="item">
			<span class="item-title">EnterAge(age): {{ age }}</span>
			<input
				class="item-input"
				v-model.number="age"
				type="number"
			/>
		</div>

		<div class="item">
			<span class="item-title">EnterMessage(lazy): {{ messageLazy }}</span>
			<input
				class="item-input"
				v-model.lazy="messageLazy"
			/>
		</div>

		<div class="item">
			<span class="item-title">EnterMessage(message): {{ messageTrim }}</span>
			<input
				class="item-input"
				v-model.trim="messageTrim"
			/>
		</div>
	</div>
</template>

<style lang="scss" scoped>
.title {
	font-size: 25px;
	margin-bottom: 15px;
}

.container {
	font-size: 14px;

	display: flex;
	flex-direction: column;
	gap: 15px;

	margin-bottom: 30px;
}

.item {
	display: flex;
	align-items: center;

	column-gap: 30px;

	&-title {
		font-size: 18px;
	}

	&-input {
		max-height: 30px;
	}
}
</style>
