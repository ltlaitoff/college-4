<script setup lang="ts"></script>

<template>
  <header class="py-5 w-full flex gap-x-24">
    <router-link
      class="text-xl text-gray-900 hover:text-sky-500 transition"
      to="/"
    >
      Weather
    </router-link>

    <nav class="flex gap-x-5">
      <router-link
        to="/"
        class="nav-link"
      >
        Home
      </router-link>
      <router-link
        to="/add-city"
        class="nav-link"
      >
        Add city
      </router-link>
    </nav>
  </header>
</template>

<style>
.nav-link {
  @apply text-gray-600 hover:text-sky-500 transition;
}

.nav-link[aria-current] {
  @apply text-pink-500 hover:text-sky-500;
}
</style>
