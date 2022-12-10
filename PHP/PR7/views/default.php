<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PR7</title>
</head>

<body>

  <form action="<?php echo "/" . SITE_ROOT . "index.php/students/addStudent" ?>" method="post">
    <input type="text" name="name" placeholder="Name" required /><br>
    <input type="number" name="group_id" placeholder="Group id" min="1" max="2" required /><br>
    <input type="submit" value="Отправить" />
  </form>

  <hr>
  <?php
  if ($students) { ?>
  <form action="<?php echo "/" . SITE_ROOT . "index.php/students/actions" ?>" method="post">
    <table>
      <tr>
        <th>Имя</th>
        <th>Группа</th>
        <th>Действие</th>
      </tr>
      <?php foreach ($students as $s) { ?>
      <tr>
        <td>
          <?php echo $s['name']; ?>
        </td>
        <td>
          <?php echo $s['group']; ?>
        </td>
        <td><button type="submit" name="delete" value="<?php echo $s['id']; ?>">Delete</button></td>
      </tr>
      <?php } ?>
    </table>
  </form>
  <?php } ?>
</body>

</html>