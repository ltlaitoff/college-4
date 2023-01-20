export const useTimer = (delayMs: number, callback: () => void) => {
  let timer: NodeJS.Timeout | undefined = undefined

  const startTimer = () => {
    timer = setTimeout(callback, delayMs)
  }

  const restartTimer = () => {
    deleteTimer()
    startTimer()
  }

  const deleteTimer = () => {
    clearTimeout(timer)
  }

  return { start: startTimer, restart: restartTimer, delete: deleteTimer }
}
