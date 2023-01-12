<script setup>
import { reactive, defineEmits } from 'vue'

const emits = defineEmits({
	addStudent: null
})

const state = reactive({
	name: '',
	group: '',
	photo: '',
	mark: 0,
	isDonePr: false
})

const stateToObject = state => {
	return {
		_id: String(Date.now()),
		name: state.name,
		group: state.group,
		photo: state.photo,
		mark: state.mark,
		isDonePr: state.isDonePr
	}
}

function addStudent() {
	emits('addStudent', stateToObject(state))
}
</script>

<template>
	<form
		class="addStudent"
		@submit.prevent="addStudent"
	>
		<label class="addStudentLabel text-red-600">
			Name
			<input
				type="text"
				v-model="state.name"
			/>
		</label>

		<label class="addStudentLabel">
			Group
			<select
				class="select"
				v-model="state.group"
			>
				<option value="1">1</option>
				<option value="2">2</option>
			</select>
		</label>

		<label class="addStudentLabel">
			Practive is done
			<input
				v-model="state.isDonePr"
				type="checkbox"
			/>
		</label>

		<button class="addStudentButton">Add student</button>
	</form>
</template>

<style lang="scss"></style>
