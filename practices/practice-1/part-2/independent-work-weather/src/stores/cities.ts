import type { CityStorageItem } from '@/types/storage'
import { defineStore } from 'pinia'
import { ref, computed } from 'vue'

export const useCitiesStore = defineStore('cities', () => {
  const citiesStore = ref<Array<CityStorageItem>>([])

  function addCity(item: CityStorageItem) {
    citiesStore.value.push(item)
  }

  const cities = computed(() => citiesStore.value)

  return { citiesStore, addCity, cities }
})
