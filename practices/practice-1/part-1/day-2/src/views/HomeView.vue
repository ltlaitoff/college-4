<script setup>
import { reactive, computed } from 'vue'
import EventName from '../components/EventName.vue'
import quotes from '@/config/quotes.js'

const state = reactive({
	type: 'all',
	red: false,
	sorting: false
})

const quotesWithAuthors = computed(() => {
	return quotes.filter(item => item.source !== '')
})

const sortedQuotes = computed(() => {
	return quotes.sort((a, b) => {
		if (a.source < b.source) {
			return 1
		}
		if (a.source > b.source) {
			return -1
		}

		return 0
	})
})
</script>

<template>
	<EventName />

	<div :class="$style.menu">
		<label :class="$style.label">
			<input
				:class="$style.radio"
				v-model="state.type"
				type="radio"
				value="all"
			/>
			All
		</label>

		<label :class="$style.label">
			<input
				:class="$style.radio"
				v-model="state.type"
				type="radio"
				value="author"
			/>
			Author
		</label>

		<label :class="$style.label">
			<input
				:class="$style.checkbox"
				v-model="state.red"
				type="checkbox"
				value="Red"
			/>
			Red
		</label>

		<label :class="$style.label">
			<input
				:class="$style.checkbox"
				v-model="state.sorting"
				type="checkbox"
				value="Sorting"
			/>
			Sorting
		</label>
	</div>

	<div :class="$style.quotes">
		<div :class="$style.quotesTitle">Quotes:</div>

		<div
			:class="$style.quote"
			v-for="quote in state.type === 'all' ? quotes : quotesWithAuthors"
			:key="quote.id"
		>
			<div
				:class="[
					$style.quoteTitle,
					state.red && quote.quote.length > 40 && $style.quoteTitleRed
				]"
			>
				{{ quote.quote }}
			</div>
			<div :class="$style.quoteAuthor">{{ quote.source }}</div>
		</div>
	</div>

	<div
		:class="[$style.quotes, $style.quotesSorted]"
		v-if="state.sorting"
	>
		<div :class="$style.quotesTitle">Sorted:</div>

		<div
			:class="$style.quote"
			v-for="quote in sortedQuotes"
			:key="quote.id"
		>
			<div
				:class="[
					$style.quoteTitle,
					state.red && quote.quote.length > 40 && $style.quoteTitleRed
				]"
			>
				{{ quote.quote }}
			</div>
			<div :class="$style.quoteAuthor">{{ quote.source }}</div>
		</div>
	</div>
</template>

<style lang="scss" module src="../style/views/HomeView.scss"></style>
