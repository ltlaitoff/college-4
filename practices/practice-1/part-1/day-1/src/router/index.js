import { createRouter, createWebHistory } from 'vue-router'

const MouseFirst = import('../views/mouse/MouseFirst.vue')
const MouseSecond = import('../views/mouse/MouseSecond.vue')
const MouseThird = import('../views/mouse/MouseThird.vue')
const MouseFour = import('../views/mouse/MouseFour.vue')
const MouseFive = import('../views/mouse/MouseFive.vue')
const MouseSix = import('../views/mouse/MouseSix.vue')
const MouseSeven = import('../views/mouse/MouseSeven.vue')
const MouseEight = import('../views/mouse/MouseEight.vue')
const MouseSixteen = import('../views/mouse/MouseSixteen.vue')
const MouseSeventeen = import('../views/mouse/MouseSeventeen.vue')
const MouseEighteen = import('../views/mouse/MouseEighteen.vue')

const routes = [
	{
		path: '/mouse-1',
		name: 'First mouse block task',
		component: MouseFirst
	},
	{ path: '/mouse-2', name: 'Second mouse block task', component: MouseSecond },
	{ path: '/mouse-3', name: 'Third mouse block task', component: MouseThird },
	{ path: '/mouse-4', name: 'Four mouse block task', component: MouseFour },
	{ path: '/mouse-5', name: 'Five mouse block task', component: MouseFive },
	{ path: '/mouse-6', name: 'Six mouse block task', component: MouseSix },
	{ path: '/mouse-7', name: 'Seven mouse block task', component: MouseSeven },
	{ path: '/mouse-8', name: 'Eight mouse block task', component: MouseEight },
	{
		path: '/mouse-16',
		name: 'Sixteen mouse block task',
		component: MouseSixteen
	},
	{
		path: '/mouse-17',
		name: 'Seventeen mouse block task',
		component: MouseSeventeen
	},
	{
		path: '/mouse-18',
		name: 'Eighteen mouse block task',
		component: MouseEighteen
	}
]

const router = createRouter({
	history: createWebHistory(import.meta.env.BASE_URL),
	routes: routes
})

export default router
