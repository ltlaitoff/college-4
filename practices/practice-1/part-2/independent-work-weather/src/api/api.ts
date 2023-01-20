import axios from 'axios'

import type { CityStorageItem } from '@/types/storage'

const API_KEY = import.meta.env.VITE_API_KEY
const HOST_DATA = import.meta.env.VITE_API_HOST_DATA
const HOST_GEO = import.meta.env.VITE_API_HOST_GEO

export const getCityWeather = (cityInfo: CityStorageItem) => {
  return axios
    .get(
      `${HOST_DATA}/weather?lat=${cityInfo.lat}&lon=${cityInfo.lon}&appid=${API_KEY}&lang=en&units=metric`
    )
    .then(response => response.data)
}

export const getCitiesListByName = (cityName: string) => {
  const LIMIT = 5

  return axios
    .get(`${HOST_GEO}/direct?q=${cityName}&limit=${LIMIT}&appid=${API_KEY}`)
    .then(response => response.data)
}
