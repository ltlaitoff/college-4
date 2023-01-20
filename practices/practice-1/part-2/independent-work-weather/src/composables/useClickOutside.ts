import { onBeforeUnmount, onMounted, type Ref } from 'vue'

export const useClickOutside = (
  component: Ref<HTMLElement | null>,
  callback: () => void
) => {
  if (!component) return

  const listener = (e: Event) => {
    if (component.value === null) return

    if (
      e.target == component.value ||
      e.composedPath().includes(component.value)
    ) {
      return
    }

    callback()
  }

  onMounted(() => {
    document.addEventListener('click', listener)
  })

  onBeforeUnmount(() => {
    document.removeEventListener('click', listener)
  })

  return { listener }
}
