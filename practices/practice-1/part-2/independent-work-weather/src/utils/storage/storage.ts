const KEY = 'weather-app'

export const set = (data: object | Array<any>) => {
  localStorage.setItem(KEY, JSON.stringify(data))
}

export const get = (): null | Array<any> => {
  const data = localStorage.getItem(KEY)

  if (data === null) return null

  return JSON.parse(data)
}
