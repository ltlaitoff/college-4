const styles = {
  get: 'color: #06b6d4',
  post: 'color: #49cc90',
  put: 'color: #fca130',
  delete: 'color: #f93e3e'
}

const getRequestPrint = (message: string) => {
  console.log('%c[GET]\t', styles.get, message)
}

const getLocalStoragePrint = (message: string) => {
  console.log('%c[GET LC]\t', styles.get, message)
}

const setLocalStoragePrint = (message: string) => {
  console.log('%c[SET LC]\t', styles.post, message)
}

export { getRequestPrint, getLocalStoragePrint, setLocalStoragePrint }
