<script setup>
/* eslint-disable */
import { ref, watch } from 'vue'
import { findCity, getDepatmentsByCity } from './api'

const cityInputValue = ref('')
const cityResults = ref([])
const choisenCityRef = ref('')
const departments = ref([])

let timer = null

watch(cityInputValue, value => {
	clearTimeout(timer)

	timer = setTimeout(() => {
		findCity(value).then(result => {
			cityResults.value = result.data.data
		})
	}, 500)
})

const choiseCity = Ref => {
	choisenCityRef.value = Ref

	console.log(Ref)

	getDepatmentsByCity(Ref).then(value => {
		departments.value = value
	})
}

/*

[
  {
    Ref: '0db1b2f1-4b3a-11e4-ab6d-005056801329',
    SettlementType: '563ced13-f210-11e3-8c4a-0050568002cf',
    Latitude: '47.786515000000000',
    Longitude: '33.583562000000000',
    Description: 'Вільне',
    DescriptionRu: 'Вольное',
    DescriptionTranslit: 'Vilne',
    SettlementTypeDescription: 'село',
    SettlementTypeDescriptionRu: 'село',
    SettlementTypeDescriptionTranslit: 'selo',
    Region: 'e4b03620-4b33-11e4-ab6d-005056801329',
    RegionsDescription: 'Апостолівський р-н',
    RegionsDescriptionRu: 'Апостоловский р-н',
    RegionsDescriptionTranslit: 'Apostolivskyi',
    Area: 'dcaad735-4b33-11e4-ab6d-005056801329',
    AreaDescription: 'Дніпропетровська область',
    AreaDescriptionRu: 'Днепропетровская область',
    AreaDescriptionTranslit: 'Dnipropetrovska',
    Index1: '53811',
    Index2: '53811',
    IndexCOATSU1: '1220382501',
    Delivery1: '1',
    Delivery2: '1',
    Delivery3: '1',
    Delivery4: '1',
    Delivery5: '1',
    Delivery6: '0',
    Delivery7: '0',
    SpecialCashCheck: 1,
    Warehouse: '1',
  },
];
*/
</script>

<template>
	<div class="wrapper">
		<label class="label">
			City:
			<input
				type="text"
				class="input searchCity"
				v-model="cityInputValue"
			/>
		</label>

		<div class="items">
			<button
				class="item"
				v-for="city in cityResults"
				:key="city.Ref"
				@click="choiseCity(city.Ref)"
			>
				{{ city.AreaDescription }} {{ city.RegionsDescription }}
				{{ city.Description }}
			</button>
		</div>

		<div
			class=""
			v-for="department in departments"
			:key="department.Ref"
		>
			{{ JSON.stringify(department) }}
		</div>
		<!-- <label class="label">
      Department:
      <input type="text" class="input searchDepartment" />
    </label> -->
	</div>
</template>

<style></style>
