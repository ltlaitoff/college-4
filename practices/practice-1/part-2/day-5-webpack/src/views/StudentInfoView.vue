<script setup>
import { onMounted, ref, computed } from 'vue'
import { useRoute } from 'vue-router'
import { getStudentInfo } from '../api'
import { getRequestPrint } from '../utils/coloredConsoleMessages'

import CrossIcon from '../assets/updating/error.svg'

const route = useRoute()

const id = ref(route.params.id)
const studentData = ref({})

const modalState = ref({
	opened: false,
	photo: studentData.value.photo
})

onMounted(() => {
	getRequestPrint(`/students/${id.value}`)

	getStudentInfo(id.value).then(value => {
		studentData.value = value.data
	})
})

const practiceStatus = computed(() => {
	return studentData.value.isDonePr ? 'Робота здана' : 'Робота не здана'
})

const onImageClick = () => {
	modalState.value.opened = true
}

const onCloseModalClick = () => {
	modalState.value.opened = false
}
</script>

<template>
	<div class="">
		<nav>
			<ul>
				<li>
					<router-link
						class="text-lg bg-clip-text font-medium text-transparent bg-gradient-to-r from-indigo-600 to-sky-800 hover:from-indigo-300 hover:to-sky-300"
						to="/"
					>
						Home
					</router-link>
				</li>
			</ul>
		</nav>

		<div class="mt-5">
			<img
				:src="studentData.photo"
				class="max-w-[500px] w-full"
				alt="studentData.name"
				@click="onImageClick"
			/>
			<div class="mt-2 flex flex-col gap-2 text-gray-600">
				<h2 class="text-xl font-medium">
					{{ studentData.name }}
				</h2>

				<div class="">
					Група:
					<span class="text-sky-600 font-medium">{{ studentData.group }}</span>
				</div>

				<div class="">
					Статус практичної роботи:
					<span
						:class="[
							'text-sky-600 font-medium',
							studentData.isDonePr ? 'text-green-600' : 'text-red-600'
						]"
					>
						{{ practiceStatus }}
					</span>
				</div>
			</div>
		</div>

		<Teleport to="body">
			<div
				v-if="modalState.opened"
				class="absolute top-0 left-0 w-full h-full flex items-center justify-center"
			>
				<div class="relative max-w-[1000px] max-h-[700px] z-10 h-full">
					<img
						:src="studentData.photo"
						class="w-full h-full"
						alt="studentData.name"
					/>
					<button
						@click="onCloseModalClick"
						class="absolute top-0 left-full -translate-x-1/2 -translate-y-1/2 w-10 bg-white rounded-full"
					>
						<CrossIcon class="h-full w-full fill-pink-600" />
					</button>
				</div>
				<div
					class="absolute top-0 left-0 bg-gray-400 w-full h-full -z-10"
				></div>
			</div>
		</Teleport>
	</div>
</template>
