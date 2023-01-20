<script setup lang="ts">
/// <reference types="vite-svg-loader" />

import { getCityWeather } from '@/api'
import type { CityStorageItem } from '@/types/storage'
import { ref, onMounted, computed, watch } from 'vue'
import getUnicodeFlagIcon from 'country-flag-icons/unicode'
import NavigatorArrow from '../assets/navigator-arrow.svg?component'

const props = defineProps<{
  item: CityStorageItem
}>()

interface CityInfo {
  coord: { lon: number; lat: number }
  weather: Array<{
    id: number
    main: string
    description: string
    icon: string
  }>
  base: string
  main: {
    temp: number
    feels_like: number
    temp_min: number
    temp_max: number
    pressure: number
    humidity: number
    sea_level: number
    grnd_level: number
  }
  visibility: number
  wind: { speed: number; deg: number; gust: number }
  clouds: { all: number }
  dt: number
  sys: { country: string; sunrise: number; sunset: number }
  timezone: number
  id: number
  name: string
  cod: number
}

const cityInfo = ref<CityInfo | null>(null)

onMounted(() => {
  getCityWeather(props.item).then(value => {
    console.log(JSON.stringify(value))
    cityInfo.value = value
  })
})

watch(
  () => props.item,
  newItem => {
    getCityWeather(newItem).then(value => {
      console.log(JSON.stringify(value))
      cityInfo.value = value
    })
  }
)

const numberToStringWithZero = (number: number) => {
  const stringifyNumber = String(number)

  if (stringifyNumber.length === 1) return '0' + stringifyNumber

  return stringifyNumber
}

const getFormatterDate = (date: Date) => {
  const data = {
    day: numberToStringWithZero(date.getUTCDate()),
    humanMonth: numberToStringWithZero(date.getUTCMonth() + 1),
    hours: numberToStringWithZero(date.getUTCHours()),
    minutes: numberToStringWithZero(date.getUTCMinutes())
  }

  const stringifiedMonth = new Intl.DateTimeFormat('en-US', {
    month: 'short'
  }).format(date)

  return `${stringifiedMonth} ${data.day}, ${data.hours}:${data.minutes}`
}

const millisecondsInSecond = 1000

const currentDate = computed(() => {
  if (!cityInfo.value) return

  const dateNow = new Date(Date.now())

  const cityMillisecondOffset = cityInfo.value?.timezone * millisecondsInSecond

  const dateWithCityOffset = new Date(dateNow.getTime() + cityMillisecondOffset)

  return getFormatterDate(dateWithCityOffset)
})

function capitalizeFirstLetter(string: string) {
  return string.charAt(0).toUpperCase() + string.slice(1)
}

const sunriseDate = computed(() => {
  if (!cityInfo.value) return

  const cityMillisecondOffset = cityInfo.value?.timezone * millisecondsInSecond

  const date = new Date(
    cityInfo.value.sys.sunrise * 1000 + cityMillisecondOffset
  )

  return `${date.getUTCHours()}:${date.getUTCMinutes()}`
})

const sunsetDate = computed(() => {
  if (!cityInfo.value) return

  const cityMillisecondOffset = cityInfo.value?.timezone * millisecondsInSecond

  const date = new Date(
    cityInfo.value.sys.sunset * 1000 + cityMillisecondOffset
  )

  return `${date.getUTCHours()}:${date.getUTCMinutes()}`
})
</script>

<template>
  <div
    v-if="cityInfo"
    class="flex flex-col gap-y-2 mt-10"
  >
    <div class="text-pink-500">{{ currentDate }}</div>

    <div class="text-2xl">
      {{ cityInfo.name }},
      <span class="text-violet-600">
        {{ cityInfo.sys.country }}
        {{ getUnicodeFlagIcon(cityInfo.sys.country) }}
      </span>
    </div>
    <div class="flex text-2xl items-center">
      <img
        class="w-14"
        :src="`http://openweathermap.org/img/wn/${cityInfo.weather[0].icon}@2x.png`"
        alt="Icon"
      />
      {{ cityInfo.main.temp }}°C
    </div>

    <div class="text-gray-700">
      Feels like:
      <span class="">{{ cityInfo.main.feels_like }}°C</span>

      {{ capitalizeFirstLetter(cityInfo.weather[0].description) }}
    </div>

    <div class="flex gap-x-2 h-6 items-center text-gray-700 fill-sky-400">
      <NavigatorArrow
        class="w-4"
        :style="`transform: rotate(${cityInfo.wind.deg + 180}deg)`"
      />
      {{ cityInfo.wind.speed }}m/s
    </div>

    <div class="text-gray-700">
      Clouds:
      {{ cityInfo.clouds.all }}%
    </div>

    <div class="text-gray-700">
      <div class="">Sunrise: {{ sunriseDate }}</div>
      <div class="">Sunset: {{ sunsetDate }}</div>
    </div>

    <div class="text-purple-400">
      [{{ cityInfo.coord.lat }}, {{ cityInfo.coord.lon }}]
    </div>
  </div>
</template>

<style scoped></style>
