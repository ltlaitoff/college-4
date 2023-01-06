<script setup>
import { RouterView, useRoute } from 'vue-router'
import { ref, watch } from 'vue'
import tasks from './config/tasks'

const currentPage = ref(null)

watch(useRoute(), (a, b) => {
	currentPage.value = tasks.tasks.find(el => {
		return el.id === Number(b.fullPath.replace('/', '').replace('mouse-', ''))
	})
})
</script>

<template>
	<main class="main">
		<h1 class="title">Day 1</h1>
		<h2 class="task-block">
			<h2 class="task-block--title">
				{{ tasks.title }}
				<span class="task-block--title-score">
					({{
						tasks.tasks.reduce(
							(acc, cur) => acc + (cur.completed ? cur.score : 0),
							0
						)
					}}
					балів)
				</span>
			</h2>
			<div class="task-block--tasks">
				<router-link
					v-for="task in tasks.tasks"
					:key="task.id"
					:to="'mouse-' + task.id"
					:class="[
						'task-block--link',
						task.completed && 'task-block--link-completed'
					]"
				>
					Завдання {{ task.id }} ({{ task.score }} бали)
				</router-link>
			</div>
		</h2>

		<div
			class="card-info"
			v-if="currentPage"
		>
			<div class="card-info--task-number">Завдання {{ currentPage.id }}</div>

			<div class="card-info--title">
				{{ currentPage.desription }}
				<span class="card-info--score">
					({{ currentPage.score }}&nbsp;балли)
				</span>
			</div>
		</div>

		<RouterView />
	</main>
</template>

<style src="./style/App.scss" lang="scss"></style>
