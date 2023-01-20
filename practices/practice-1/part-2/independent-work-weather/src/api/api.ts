import axios from 'axios'

import type { CityStorageItem } from '@/types/storage'

const API_KEY = import.meta.env.VITE_API_KEY

export const getCityWeather = (cityInfo: CityStorageItem) => {
  return axios
    .get(
      `/weather?lat=${cityInfo.lat}&lon=${cityInfo.lon}&appid=${API_KEY}&lang=en&units=metric`
    )
    .then(response => response.data)
}
