<script>
export default {
	methods: {
		onClick() {
			window.alert(this.$el.textContent)
		}
	}
}

// const onClick = e => {
// window.alert(e.target.textContent)
// 	}
</script>

<template>
	<button
		@click="onClick"
		:class="$style.button"
	>
		Саме цей текст виводіть
	</button>
</template>

<style src="../../style/mouse/MouseSix.scss" lang="scss" module></style>
