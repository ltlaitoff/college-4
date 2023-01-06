<script>
export default {
	data() {
		return {
			num1: 100,
			num2: 200,
			total: '',
			styleobj: {
				width: '100px',
				height: '100px',
				backgroundColor: 'red'
			}
		}
	},
	methods: {
		changeBgColor: function () {
			this.styleobj.backgroundColor = 'green'
		},
		originalColor: function () {
			this.styleobj.backgroundColor = 'red'
		}
	}
}
</script>

<template>
	<div class="title">Example 2</div>

	<div class="container">
		<div
			v-bind:style="styleobj"
			v-on:mouseover="changeBgColor"
			v-on:mouseout="originalColor"
		></div>
	</div>
</template>

<style lang="scss" scoped>
.title {
	font-size: 25px;
	margin-bottom: 15px;
}

.container {
	margin-bottom: 50px;
}
</style>
