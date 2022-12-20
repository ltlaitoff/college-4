<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="css/style.css">
  <title>PR9</title>

  <script src="https://cdn.jsdelivr.net/npm/vue/dist/vue.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>
</head>

<body>
  <ul>
    <li><a href="/">Students</a></li>
    <li><a href="/index.php/subjects">Subjects</a></li>
    <li><a href="/index.php/uspishnist">Uspishnist</a></li>
  </ul>
  <hr>

  <div id="app">
    <form @submit.prevent="addStudent()">
      <div class="msg" v-if="msg">{{msg}}</div>
      <input type="text" v-model="newItem.name" placeholder="Name" required />
      <br>

      <select v-model="newItem.group_id" v-if="groups">
        <option value="">None</option>
        <option v-for="group in groups" :key="group.id" :value="group.id">{{group.name}}</option>
      </select>

      <br>
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
        <td> <input v-model="student.name"></td>
        <td>
          <select v-model="student.group_id" v-if="groups">
            <option value="">None</option>
            <option v-for="group in groups" :key="group.id" :value="group.id">{{group.name}}</option>
          </select>
        </td>
        <td>
          <button type="submit" @click.prevent="updateStudent(s);">Update</button>
        </td>
        <td>
          <button type="submit" @click.prevent="deleteStudent(s);">Delete</button>
        </td>
      </tr>
    </table>
  </div>

  <script>
  <?php require_once("scripts/default.js"); ?>
  </script>
</body>

</html>