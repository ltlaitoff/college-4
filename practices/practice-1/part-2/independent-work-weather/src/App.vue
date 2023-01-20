<script setup lang="ts">
import { watch, onMounted } from 'vue'
import { RouterView } from 'vue-router'

import type { CityStorageItem } from './types/storage'
import HeaderMain from './components/HeaderMain.vue'
import { useCitiesStore } from './stores/cities'
import { set as setStorage, get as getStorage } from './utils/storage'

const citiesStore = useCitiesStore()

watch(
  () => citiesStore.cities,
  state => setStorage(state),
  { deep: true }
)

onMounted(() => {
  const storageData = getStorage()
  if (storageData === null) return

  storageData.map((item: CityStorageItem) => {
    citiesStore.addCity(item)
  })
})
</script>

<template>
  <main class="max-w-[1440px] m-auto px-10">
    <HeaderMain />

    <RouterView />
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
