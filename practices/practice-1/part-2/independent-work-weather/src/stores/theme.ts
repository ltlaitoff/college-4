import { defineStore } from 'pinia'
import { ref, computed } from 'vue'

type ThemeType = 'light' | 'dark'
export const useTheme = defineStore('theme', () => {
  const themeStore = ref<ThemeType>('light')

  function setTheme(theme: ThemeType) {
    themeStore.value = theme
  }

  const theme = computed(() => themeStore.value)

  return { themeStore, setTheme, theme }
})
