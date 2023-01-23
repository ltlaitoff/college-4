<script setup>
import { computed } from 'vue'
import { RouterView } from 'vue-router'
import { useStore } from 'vuex'

const store = useStore()

const themeIsDark = computed(() => {
	return store.getters['theme/getTheme'] === 'dark'
})
/* */
</script>

<template>
	<main :class="['h-full', themeIsDark && 'dark']">
		<div class="box-border p-10 bg-white dark:bg-gray-700 h-full">
			<RouterView />
		</div>
	</main>
</template>
