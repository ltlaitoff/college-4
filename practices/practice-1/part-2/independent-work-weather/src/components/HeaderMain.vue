<script setup lang="ts">
import { useTheme } from '@/stores/theme'
import { computed, ref, watch } from 'vue'

const themeStore = useTheme()

const isDark = ref<boolean>(themeStore.theme === 'dark')
const HTML_ROOT_ELEMENT = document.documentElement

const themeButtonText = computed(() => {
  return isDark.value ? 'dark' : 'light'
})

function swithTheme() {
  HTML_ROOT_ELEMENT.classList.toggle('dark')
  isDark.value = !isDark.value

  themeStore.setTheme(isDark.value ? 'dark' : 'light')
}

watch(
  () => themeStore.theme,
  value => {
    isDark.value = themeStore.theme === 'dark'

    if (isDark.value) {
      HTML_ROOT_ELEMENT.classList.add('dark')
    }
  }
)
</script>

<template>
  <header class="py-5 w-full flex gap-x-24">
    <router-link
      class="text-xl dark:text-gray-100 text-gray-900 hover:text-sky-500 dark:hover:text-sky-500 transition"
      to="/"
    >
      Weather
    </router-link>

    <nav class="flex gap-x-5">
      <router-link
        to="/"
        class="dark:text-gray-100 dark:hover:text-sky-500 text-gray-600 hover:text-sky-500 transition nav-link"
      >
        Home
      </router-link>
      <router-link
        to="/add-city"
        class="dark:text-gray-100 dark:hover:text-sky-500 text-gray-600 hover:text-sky-500 transition nav-link"
      >
        Add city
      </router-link>

      <button
        class="dark:text-gray-100 dark:hover:text-sky-500 text-gray-600 hover:text-sky-500 transition nav-link"
        @click="swithTheme"
      >
        {{ themeButtonText }}
      </button>
    </nav>
  </header>
</template>

<style>
.nav-link[aria-current] {
  @apply !text-pink-400 hover:!text-sky-500 dark:!text-pink-400 dark:hover:!text-sky-500;
}
</style>
