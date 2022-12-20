<script>
import {
  addUspishnist as addUspishnistAPI,
  getUspishnist as getUspishnistAPI,
  updateUspishnist as updateUspishnistAPI,
  deleteUspishnist as deleteUspishnistAPI,
} from '../api/api.js'

const TIME_DELAY = 5000

export default {
  data() {
    return {
      newMark: 0,
      newStudentId: -1,
      newSubjectId: -1,
      message: '',
      uspishnist: [],
      students: [],
      subjects: [],
    }
  },

  mounted() {
    this.getData()
  },

  methods: {
    getData() {
      getUspishnistAPI().then((response) => {
        if (response.data.uspishnist) {
          this.uspishnist = response.data.uspishnist
        }

        if (response.data.students) {
          this.students = response.data.students
        }

        if (response.data.subjects) {
          this.subjects = response.data.subjects
        }
      })
    },

    addUspishnist() {
      if (this.newMark === 0) return
      if (this.newStudentId === -1) return
      if (this.newSubjectId === -1) return

      const formData = new FormData()

      formData.append('mark', this.newMark)
      formData.append('p_id', this.newSubjectId)
      formData.append('s_id', this.newStudentId)

      addUspishnistAPI(formData).then((response) => {
        console.log(response)

        this.getData()
        this.newItem = []
        this.message = 'Оцінка була успішно додана'

        setTimeout(() => {
          this.message = ''
        }, TIME_DELAY)
      })
    },

    updateUspishnist(uspishnist) {
      if (!uspishnist) return

      console.log(uspishnist)
      const formData = new FormData()

      formData.append('mark', uspishnist.mark)
      formData.append('p_id', uspishnist.p_id)
      formData.append('s_id', uspishnist.s_id)
      formData.append('update', uspishnist.id)

      updateUspishnistAPI(formData).then((response) => {
        console.log(response)

        this.getData()
        this.newItem = []
        this.message = 'Оцінка була успішно зміненна'

        setTimeout(() => {
          this.message = ''
        }, TIME_DELAY)
      })
    },

    deleteUspishnist(uspishnist) {
      if (!uspishnist) return

      const formData = new FormData()

      formData.append('mark', uspishnist.mark)
      formData.append('p_id', uspishnist.p_id)
      formData.append('s_id', uspishnist.s_id)
      formData.append('delete', uspishnist.id)

      deleteUspishnistAPI(formData).then(() => {
        this.getData()
        this.newItem = []
        this.message = 'Оцінка був успішно видалена'

        setTimeout(() => {
          this.message = ''
        }, TIME_DELAY)
      })
    },
  },
}
</script>

<template>
  {{ message }}
  <form @submit.prevent="addUspishnist">
    <input
      v-model="newMark"
      type="number"
      name="mark"
      placeholder="Mark"
      required
    /><br />

    <select name="s_id" v-model="newStudentId">
      <option disabled value="">None</option>
      <option v-for="student in students" :key="student.id" :value="student.id">
        {{ student.name }}
      </option>
    </select>

    <br />

    <select name="p_id" v-model="newSubjectId">
      <option disabled value="">None</option>
      <option v-for="subject in subjects" :key="subject.id" :value="subject.id">
        {{ subject.name }}
      </option>
    </select>

    <br />
    <input type="submit" value="Отправить" />
  </form>

  <hr />

  <form v-if="uspishnist.length !== 0">
    <table>
      <tr>
        <th>Оцінка</th>
        <th>Студент</th>
        <th>Група</th>
        <th>Дія</th>
      </tr>
      <tr v-for="uspishnistItem in uspishnist" :key="uspishnistItem.id">
        <td>
          <input
            type="number"
            :name="`mark[${uspishnistItem.id}]`"
            placeholder="Mark"
            required
            v-model="uspishnistItem.mark"
          />
        </td>
        <td>
          <select
            :name="`s_id[${uspishnistItem.id}]`"
            v-model="uspishnistItem.s_id"
          >
            <option value="">None</option>

            <option
              v-for="student in students"
              :key="student.id"
              :value="student.id"
              :selected="uspishnistItem.s_id === student.id"
            >
              {{ student.name }}
            </option>
          </select>
        </td>

        <td>
          <select
            :name="`p_id[${uspishnistItem.id}]`"
            v-model="uspishnistItem.p_id"
          >
            <option value="">None</option>

            <option
              v-for="subject in subjects"
              :key="subject.id"
              :value="subject.id"
              :selected="uspishnistItem.p_id == subject.id"
            >
              {{ subject.name }}
            </option>
          </select>
        </td>
        <td>
          <button
            type="submit"
            name="update"
            @click.prevent="updateUspishnist(uspishnistItem)"
            :value="uspishnistItem.id"
          >
            Update
          </button>
          <button
            type="submit"
            name="delete"
            :value="uspishnistItem.id"
            @click.prevent="deleteUspishnist(uspishnistItem)"
          >
            Delete
          </button>
        </td>
      </tr>
    </table>
  </form>
</template>
