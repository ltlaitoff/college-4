<script setup>
/* eslint-disable */
import { ref, watch } from 'vue'
import { findCity, getDepatmentsByCity } from './api'

const cityInputValue = ref('')
const cityResults = ref([])
const choisenCityRef = ref('')
const departments = ref([])
const choisenDepartment = ref(null)

let timer = null

watch(cityInputValue, value => {
	clearTimeout(timer)

	timer = setTimeout(() => {
		choisenCityRef.value = ''
		departments.value = []
		choisenDepartment.value = null

		findCity(value).then(result => {
			cityResults.value = result.data.data
		})
	}, 500)
})

const choiseCity = Ref => {
	choisenCityRef.value = Ref

	console.log(Ref)

	getDepatmentsByCity(Ref).then(value => {
		departments.value = value.data.data
	})
}

const choiseDepartment = departmentInfo => {
	choisenDepartment.value = departmentInfo
}
</script>

<template>
	<main>
		<div class="m-5 flex gap-x-10 items-start">
			<label class="font-light text-lg flex gap-x-3 items-start">
				City:
				<div class="relative w-[18em]">
					<input
						type="text"
						:class="[
							`w-full text-base border rounded border-gray-400 px-4 py-2 hover:border-gray-600`,
							cityResults.length !== 0 && 'rounded-b-none'
						]"
						v-model="cityInputValue"
					/>
					<div
						v-if="cityResults.length !== 0"
						class="py-2 w-full flex flex-col border rounded rounded-t-none bg-white"
					>
						<button
							:class="[
								'px-5 py-2 w-full gap-x-7 flex items-center hover:bg-gray-200 justify-between',
								choisenCityRef === city.Ref && 'bg-pink-100'
							]"
							v-for="city in cityResults"
							:key="city.Ref"
							@click="choiseCity(city.Ref)"
						>
							<span
								class="text-start font-medium bg-clip-text text-transparent bg-gradient-to-r from-indigo-600 to-violet-700"
							>
								{{ city.Description }}
							</span>
							<div class="max-w-[10em] text-sm text-gray-800 text-start">
								{{ city.AreaDescription }}
								{{ city.RegionsDescription }}
							</div>
						</button>
					</div>
				</div>
			</label>

			<div class="">
				<div
					v-if="departments.length !== 0"
					class="py-2 flex flex-col border rounded rounded-t-none bg-white"
				>
					<button
						:class="[
							'px-5 py-2 w-full gap-x-7 flex items-center hover:bg-gray-200 justify-between',
							choisenDepartment &&
								choisenDepartment.Ref === department.Ref &&
								'bg-pink-100'
						]"
						v-for="department in departments"
						:key="department.Ref"
						@click="choiseDepartment(department)"
					>
						{{ department.Description }}
					</button>
				</div>

				<div v-else>departments not found</div>
			</div>
		</div>

		<div
			class="m-10 border rounded border-indigo-600 p-5 flex flex-col gap-3"
			v-if="choisenDepartment"
		>
			<div class="text-lg font-semibold">
				{{ choisenDepartment.Description }}
			</div>

			<div class="">
				Адреса:
				{{ choisenDepartment.ShortAddress }}
			</div>

			<div
				class=""
				v-if="choisenDepartment.Phone"
			>
				Phone:
				<a
					class="bg-clip-text text-transparent bg-gradient-to-r from-pink-600 to-red-800 hover:from-indigo-500 hover:to-pink-600"
					:href="`tel:${choisenDepartment.Phone}`"
				>
					+{{ choisenDepartment.Phone }}
				</a>
			</div>

			<div class="">
				Наявність каси NovaPay :
				{{ choisenDepartment.PostFinance === '1' ? 'Так' : 'Ні' }}
			</div>
			<div class="">
				Наявність пос терміналу :
				{{ choisenDepartment.POSTerminal === '1' ? 'Так' : 'Ні' }}
			</div>

			<div class="flex flex-col gap-5">
				Обмеження розмірів:
				<table class="tableCustom">
					<tr>
						<th class="table-head-item"></th>
						<th class="table-head-item">Ширина</th>
						<th class="table-head-item">Висота</th>
						<th class="table-head-item">Довжина</th>
					</tr>

					<tr>
						<th class="table-head-item">Для надсилання</th>
						<td class="table-item">
							{{ choisenDepartment.SendingLimitationsOnDimensions.Width }}
						</td>
						<td class="table-item">
							{{ choisenDepartment.SendingLimitationsOnDimensions.Height }}
						</td>
						<td class="table-item">
							{{ choisenDepartment.SendingLimitationsOnDimensions.Length }}
						</td>
					</tr>

					<tr>
						<th class="table-head-item">Для отримання</th>
						<td class="table-item">
							{{ choisenDepartment.ReceivingLimitationsOnDimensions.Width }}
						</td>
						<td class="table-item">
							{{ choisenDepartment.ReceivingLimitationsOnDimensions.Height }}
						</td>
						<td class="table-item">
							{{ choisenDepartment.ReceivingLimitationsOnDimensions.Length }}
						</td>
					</tr>
				</table>

				Розклад роботи:
				<table class="tableCustom">
					<tr>
						<th class="table-head-item"></th>
						<th class="table-head-item">Приймання відправлень</th>
						<th class="table-head-item">Відправки день в день</th>
						<th class="table-head-item">Робота</th>
					</tr>

					<tr
						v-for="day in Object.keys(choisenDepartment.Schedule)"
						:key="day"
					>
						<th class="table-head-item">{{ day }}</th>
						<td class="table-item">{{ choisenDepartment.Reception[day] }}</td>
						<td class="table-item">{{ choisenDepartment.Delivery[day] }}</td>
						<td class="table-item">{{ choisenDepartment.Schedule[day] }}</td>
					</tr>
				</table>
			</div>
		</div>
	</main>
</template>

<style>
.tableCustom {
	@apply text-center inline;
}

.table-head-item {
	@apply px-4 py-2 border border-indigo-500 font-semibold;
}

.table-item {
	@apply px-4 py-2 border border-indigo-500;
}
</style>
