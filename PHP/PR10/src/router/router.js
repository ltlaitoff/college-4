import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import SubjectsView from '../views/SubjectsView.vue'
import UspishnistView from '../views/UspishnistView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
  },
  {
    path: '/uspishnist',
    name: 'uspishnist',
    component: UspishnistView,
  },
  {
    path: '/subjects',
    name: 'subjects',
    component: SubjectsView,
  },
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: routes,
})

export default router
