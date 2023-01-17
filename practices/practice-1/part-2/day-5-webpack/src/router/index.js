import { createRouter, createWebHashHistory } from 'vue-router'

import HomeView from '../views/HomeView.vue'
import StudentInfoView from '../views/StudentInfoView.vue'

const routes = [
	{
		path: '/',
		name: 'Home',
		component: HomeView
	},
	{
		path: '/student-info/:id',
		name: 'Student info',
		component: StudentInfoView,
		props: true
	}
]

const router = createRouter({
	history: createWebHashHistory(),
	routes: routes
})

export default router
