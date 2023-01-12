<script setup>
import { ref, onMounted, computed } from 'vue'
import { getCourse } from './api/api'

const currencyCourses = ref([])
const fromCurrency = ref('980')
const toCurrency = ref('840')
const value = ref(1)

const findCourse = () => {
	return currencyCourses.value.find(item => {
		if (
			item.currencyCodeA == fromCurrency.value &&
			item.currencyCodeB == toCurrency.value
		)
			return item

		if (
			item.currencyCodeA == toCurrency.value &&
			item.currencyCodeB == fromCurrency.value
		)
			return item
	})
}

onMounted(() => {
	getCourse().then(value => {
		currencyCourses.value = value
	})
})

const getCurrencyName = code => {
	const data = {
		978: 'EUR',
		840: 'USD',
		980: 'UAH'
	}

	return data[code]
}

const buyValue = computed(() => {
	if (fromCurrency.value === toCurrency.value) return 1

	const currentCourse = findCourse()
	if (currentCourse === undefined) return

	if (currentCourse.currencyCodeA == fromCurrency.value)
		return currentCourse.rateBuy

	return 1 / currentCourse.rateBuy
})

const saleValue = computed(() => {
	if (fromCurrency.value === toCurrency.value) return 1

	const currentCourse = findCourse()
	if (currentCourse === undefined) return

	if (currentCourse.currencyCodeA == fromCurrency.value)
		return currentCourse.rateSell

	return 1 / currentCourse.rateSell
})
</script>

<template>
	<main class="m-10">
		<label>
			{{ getCurrencyName(fromCurrency) }}:
			<input
				class="border rounded border-gray-500 pl-2"
				type="number"
				v-model.number="value"
			/>
		</label>

		<div class="mt-5">
			{{ getCurrencyName(toCurrency) }}:
			<label>
				Buy:
				<input
					class="border rounded border-gray-500 pl-2 bg-gray-200"
					type="text"
					:value="(buyValue * value).toFixed(2)"
					disabled
				/>
			</label>
			<label>
				Sale:
				<input
					class="border rounded border-gray-500 pl-2 bg-gray-200"
					type="text"
					:value="(saleValue * value).toFixed(2)"
					disabled
				/>
			</label>
		</div>

		<div class="mt-5">
			From currency
			<select
				v-model="fromCurrency"
				class="border border-gray-300 rounded p-1"
			>
				<option value="980">UAH</option>
				<option value="978">EUR</option>
				<option value="840">USD</option>
			</select>

			To currency:
			<select
				v-model="toCurrency"
				class="border border-gray-300 rounded p-1"
			>
				<option value="980">UAH</option>
				<option value="978">EUR</option>
				<option value="840">USD</option>
			</select>
		</div>
	</main>
</template>

<style></style>
