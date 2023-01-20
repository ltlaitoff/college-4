<script setup lang="ts">
import { ref, computed, watch } from 'vue'
import type { CityStorageItem } from '@/types/storage'
import { useClickOutside } from '@/composables/useClickOutside'
import { useTimer } from '../composables/useTimer'

const props = defineProps<{
  cities: Array<CityStorageItem>
}>()

const emits = defineEmits<{
  (e: 'change', newChoicedCity: CityStorageItem | null): void
}>()

const currentSearchValue = ref<string>('')
const showSelectList = ref<boolean>(false)

const searchItems = computed(() => {
  if (currentSearchValue.value === '') return null

  return props.cities.filter(item => {
    const stringForFind = item.name + item.country + item.state

    return (
      stringForFind.indexOf(currentSearchValue.value.split(' ').join('')) >= 0
    )
  })
})

const onItemClick = (item: CityStorageItem) => {
  currentSearchValue.value =
    item.name + ' ' + item.country + ' ' + `${item.state || ''}`
  emits('change', item)

  showSelectList.value = false
}

const onInputFocus = () => {
  showSelectList.value = true
}

const mainElementRef = ref<HTMLLabelElement | null>(null)

/*
	TODO:
	[ ] Hide select list on click outside
	[ ] Make timer and requests to a server 
*/

useClickOutside(mainElementRef, () => {
  showSelectList.value = false
})
</script>

<template>
  <div
    ref="mainElementRef"
    class="inline-flex gap-x-3"
  >
    <span class="py-2">Choice city:</span>
    <div class="w-72 relative">
      <input
        class="border rounded border-gray-400 py-2 px-4 w-full"
        type="text"
        v-model="currentSearchValue"
        @focus="onInputFocus"
      />
      <div
        class="absolute flex flex-col mt-2 w-72 border rounded p-1 gap-y-1 bg-white"
        v-if="
          showSelectList && searchItems !== null && searchItems.length !== 0
        "
      >
        <button
          class="p-2 flex gap-x-5 justify-between hover:bg-pink-200 rounded items-center"
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

<style scoped></style>
