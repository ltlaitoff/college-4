<script>
// import {
//   getSubjects as getSubjectsAPI,
//   addSubject as addSubjectAPI,
//   updateSubject as updateSubjectAPI,
//   deleteSubject as deleteSubjectAPI,
// } from '../api/api.js'

// const TIME_DELAY = 5000

// export default {
//   data() {
//     return {
//       message: '',
//       subjects: [],
//       newSubject: '',
//     }
//   },

//   mounted() {
//     this.getData()
//   },

//   methods: {
//     getData() {
//       getSubjectsAPI().then((response) => {
//         if (response.data.subjects) {
//           this.subjects = response.data.subjects
//         }
//       })
//     },

//     toFormData(subject) {
//       const formData = new FormData()

//       formData.append('name', subject.name)
//       subject.id && formData.append('id', subject.id)

//       return formData
//     },

//     addSubject() {
//       if (this.newSubject === '') return

//       const formData = this.toFormData({ name: this.newSubject })

//       addSubjectAPI(formData).then((response) => {
//         console.log(response)

//         this.getData()
//         this.newItem = []
//         this.message = 'Предмет був успішно доданий'

//         setTimeout(() => {
//           this.message = ''
//         }, TIME_DELAY)
//       })
//     },

//     updateSubject(subject) {
//       if (!subject) return

//       const formData = this.toFormData(subject)
//       formData.append('update', subject.id)

//       updateSubjectAPI(formData).then((response) => {
//         console.log(response)

//         this.getData()
//         this.newItem = []
//         this.message = 'Предмет був успішно зміненний'

//         setTimeout(() => {
//           this.message = ''
//         }, TIME_DELAY)
//       })
//     },

//     deleteSubject(subject) {
//       if (!subject) return

//       const formData = this.toFormData(subject)
//       formData.append('delete', subject.id)

//       deleteSubjectAPI(formData).then(() => {
//         this.getData()
//         this.newItem = []
//         this.message = 'Предмет був успішно видалений'

//         setTimeout(() => {
//           this.message = ''
//         }, TIME_DELAY)
//       })
//     },
//   },
// }
</script>

<template>
  test
  <!-- <form @submit.prevent="addSubject" method="POST">
    {{ message }}
    <input
      v-model="newSubject"
      type="text"
      name="name"
      placeholder="Name"
      required
    />

    <input type="submit" value="Отправить" />
  </form>

  <hr />

  <form method="POST" v-if="subjects">
    <table>
      <tr>
        <th>Ім'я</th>
        <th>Дія</th>
      </tr>

      <tr v-for="subject in subjects" :key="subject.id">
        <td>
          <input
            v-model="subject.name"
            type="text"
            :name="subject.name"
            placeholder="Name"
            required
          />
        </td>

        <td>
          <button type="submit" @click.prevent="updateSubject(subject)">
            Update
          </button>
          <button type="submit" @click.prevent="deleteSubject(subject)">
            Delete
          </button>
        </td>
      </tr>
    </table>
  </form> -->
</template>
