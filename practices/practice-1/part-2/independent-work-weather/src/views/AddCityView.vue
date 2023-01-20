<script setup lang="ts">
import { getCitiesListByName } from '@/api'
import type { CityStorageItem } from '@/types/storage'
import { ref, watch } from 'vue'
import { useTimer } from '../composables/useTimer'
import { useCitiesStore } from '../stores/cities'
import { getRequestPrint } from '@/utils/coloredConsoleMessages'

const inputValue = ref('')
const searchItems = ref<Array<CityStorageItem> | null>(null)
const showSelectList = ref<boolean>(false)
const cityAdded = ref<boolean>(false)

const timer = useTimer(500, () => {
  if (inputValue.value === '') return

  getCitiesListByName(inputValue.value).then(value => {
    getRequestPrint(`getCitiesListByName`)
    searchItems.value = value
  })

  if (cityAdded.value) {
    cityAdded.value = false
  }
})

watch(
  () => inputValue.value,
  () => {
    timer.restart()
  }
)

const citiesStore = useCitiesStore()

const onItemClick = (item: CityStorageItem) => {
  inputValue.value =
    item.name + ' ' + item.country + ' ' + `${item.state || ''}`

  showSelectList.value = false

  citiesStore.addCity(item)
  cityAdded.value = true
}

const onInputFocus = () => {
  showSelectList.value = true
}

const mainElementRef = ref<HTMLLabelElement | null>(null)
</script>

<template>
  <div
    ref="mainElementRef"
    class="inline-flex gap-x-3"
  >
    <span class="py-2 dark:text-gray-100">Choice city for adding:</span>
    <div class="w-72 relative">
      <input
        :class="[
          `border rounded border-gray-400 py-2 px-4 w-full bg-white dark:border-gray-500 dark:bg-gray-600 dark:text-white`,
          {
            'border-green-500 bg-green-100 dark:border-green-600 dark:bg-green-400 dark:':
              cityAdded
          }
        ]"
        type="text"
        v-model="inputValue"
        @focus="onInputFocus"
      />
      <div
        class="absolute flex flex-col mt-2 w-72 border rounded p-1 gap-y-1 bg-white dark:bg-gray-600 dark:border-gray-500"
        v-if="
          showSelectList && searchItems !== null && searchItems.length !== 0
        "
      >
        <button
          class="p-2 flex gap-x-5 justify-between hover:bg-pink-200 dark:hover:bg-pink-400 rounded items-center dark:bg-gray-600 dark:text-white"
          v-for="searchItem in searchItems"
          :key="searchItem.name + searchItem.lat + searchItem.lon"
          @click="onItemClick(searchItem)"
        >
          <div class="font-medium">
            {{ searchItem.name }}
          </div>
          <div class="flex gap-x-2 flex-wrap">
            {{ searchItem.country }}
            <span v-if="searchItem.state">{{ searchItem.state }}</span>
          </div>
        </button>
      </div>
    </div>
  </div>
</template>
