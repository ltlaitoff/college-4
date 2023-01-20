<script setup lang="ts">
import type { CityStorageItem } from '@/types/storage'
import ChoiceCity from '@/components/ChoiceCity.vue'
import CityInfo from '@/components/CityInfo.vue'

import { ref } from 'vue'

const basicStorage = ref<Array<CityStorageItem>>([
  {
    name: 'Zaporizhzhia',
    lat: 47.8507859,
    lon: 35.1182867,
    country: 'UA',
    state: 'Zaporizhia Oblast'
  },
  {
    name: 'Beverly Hills',
    lat: 34.0901,
    lon: -118.4065,
    country: 'US'
  },
  {
    name: 'London',
    lat: 51.5085,
    lon: -0.1257,
    country: 'GB'
  },
  {
    name: 'London',
    lat: 42.9834,
    lon: -81.233,
    country: 'CA'
  },
  {
    name: 'London',
    lat: 39.8865,
    lon: -83.4483,
    country: 'US',
    state: 'OH'
  },
  {
    name: 'London',
    lat: 37.129,
    lon: -84.0833,
    country: 'US',
    state: 'KY'
  },
  {
    name: 'London',
    lat: 36.4761,
    lon: -119.4432,
    country: 'US',
    state: 'CA'
  }
])
const choicedCity = ref<CityStorageItem | null>(null)

const changeChoicedCity = (newChoicedCity: CityStorageItem | null) => {
  choicedCity.value = newChoicedCity
}
</script>

<template>
  <ChoiceCity
    :cities="basicStorage"
    @change="changeChoicedCity"
  />
  <CityInfo
    v-if="choicedCity !== null"
    :item="choicedCity"
  />
</template>
