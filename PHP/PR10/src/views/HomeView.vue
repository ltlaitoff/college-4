<script>
import { getDataFromAPI, addUserToAPI, actionsAPI } from '../api/api.js'
const TIME_DELAY = 5000

export default {
  data() {
    return {
      newItem: [],
      msg: '',
      students: [],
      groups: [],
    }
  },

  mounted() {
    this.getData()
  },

  methods: {
    getData() {
      getDataFromAPI().then((response) => {
        console.log(response)

        if (response.data.students) {
          this.students = response.data.students
        }

        if (response.data.groups) {
          this.groups = response.data.groups
        }
      })
    },

    toFormData(object) {
      const formData = new FormData()

      Object.entries(object).forEach(([key, value]) => {
        formData.append(key, value)
      })

      return formData
    },

    addStudent() {
      if (!this.newItem) return

      const formData = this.toFormData(this.newItem)

      addUserToAPI(formData).then((response) => {
        console.log(response)

        this.getData()
        this.newItem = []
        this.msg = 'Студент був успішно доданий'

        setTimeout(() => {
          this.msg = ''
        }, TIME_DELAY)
      })
    },

    updateStudent(student) {
      if (!student) return

      const formData = this.toFormData(student)
      formData.append('update', student.id)

      actionsAPI(formData).then(() => {
        this.getData()
        this.newItem = []
        this.msg = 'Студент був успішно змінений'

        setTimeout(() => {
          this.msg = ''
        }, TIME_DELAY)
      })
    },

    deleteStudent(student) {
      if (!student) return

      const formData = this.toFormData(student)
      formData.append('delete', student.id)

      actionsAPI(formData).then(() => {
        this.getData()
        this.newItem = []
        this.msg = 'Студент був успішно видалений'

        setTimeout(() => {
          this.msg = ''
        }, TIME_DELAY)
      })
    },
  },
}
</script>

<template>
  <form @submit.prevent="addStudent()">
    <div class="msg" v-if="msg">{{ msg }}</div>
    <input type="text" v-model="newItem.name" placeholder="Name" required />
    <br />

    <select v-model="newItem.group_id" v-if="groups">
      <option value="">None</option>
      <option v-for="group in groups" :key="group.id" :value="group.id">
        {{ group.name }}
      </option>
    </select>

    <br />
    <input type="submit" value="Додати" />
  </form>

  <table v-if="students">
    <tr>
      <th>Ім'я</th>
      <th>Група</th>
      <th>Оновити</th>
      <th>Видалити</th>
    </tr>
    <tr v-for="student in students" :key="student.name">
      <td>
        <input v-model="student.name" />
      </td>

      <td>
        <select v-model="student.group_id" v-if="groups">
          <option value="">None</option>
          <option v-for="group in groups" :key="group.id" :value="group.id">
            {{ group.name }}
          </option>
        </select>
      </td>
      <td>
        <button type="submit" @click.prevent="updateStudent(student)">
          Update
        </button>
      </td>
      <td>
        <button type="submit" @click.prevent="deleteStudent(student)">
          Delete
        </button>
      </td>
    </tr>
  </table>
</template>
