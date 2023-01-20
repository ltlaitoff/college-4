<script setup lang="ts">
import type { CityStorageItem } from '@/types/storage'
import ChoiceCity from '@/components/ChoiceCity.vue'
import CityInfo from '@/components/CityInfo.vue'
import { ref } from 'vue'
import { useCitiesStore } from '@/stores/cities'

const citiesStore = useCitiesStore()

const choicedCity = ref<CityStorageItem | null>(null)

const changeChoicedCity = (newChoicedCity: CityStorageItem | null) => {
  choicedCity.value = newChoicedCity
}
</script>

<template>
  <ChoiceCity
    :cities="citiesStore.cities"
    @change="changeChoicedCity"
  />
  <CityInfo
    v-if="choicedCity !== null"
    :item="choicedCity"
  />
</template>
