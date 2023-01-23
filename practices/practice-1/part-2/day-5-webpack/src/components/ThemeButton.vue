<script setup>
import { computed } from 'vue'
import { useStore } from 'vuex'

const store = useStore()

const onClick = () => {
	store.commit('theme/toggleTheme')
}

const currentTheme = computed(() => {
	return store.getters['theme/getTheme']
})
</script>

<template>
	<button
		@click="onClick"
		:class="[
			'mb-3 capitalize fill-gray-400 flex text-gray-800 dark:text-gray-200 gap-2 text-base font-light  border focus-visible:shadow-[0_0_20px_0_rgba(0,0,0,0.15)] transition border-neutral-300 dark:border-gray-500 rounded focus-visible:border-sky-300 focus-visible:outline-none py-2 px-6'
		]"
	>
		{{ currentTheme }}
	</button>
</template>
