<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PR8</title>
</head>


<body>
  <ul style="display: flex; column-gap: 10px; list-style-type: none;">
    <li><a href="/">Students</a></li>
    <li><a href="/index.php/subjects">Subjects</a></li>
    <li><a href="/index.php/uspishnist">Uspishnist</a></li>
  </ul>

  <form action="/index.php/students/addStudent" method="POST">
    <input type="text" name="name" placeholder="Name" required /><br>
    <!-- <input type = "number" name = "group_id" placeholder="Group id" min="1" max="2" required /><br> -->
    <select name="group_id">
      <option value="">None</option>
      <?php if ($groups) { ?>
      <? foreach ($groups as $g) { ?>
      <option value="<?php echo $g['id']; ?>"><?php echo $g['name']; ?></option>
      <? } ?>
      <? } ?>
    </select>
    <br>
    <input type="submit" value="Отправить" />
  </form>

  <hr>
  <?
  if ($students) { ?>
  <form method="POST" action="/index.php/students/actions">
    <table>
      <tr>
        <th>Ім'я</th>
        <th>Група</th>
        <th>Дія</th>
      </tr>
      <? foreach ($students as $s) { ?>
      <tr>
        <td> <input type="text" name="name[<? echo $s['id']; ?>]" placeholder="Name" required
            value="<? echo $s['name']; ?>"> </td>
        <td>
          <select name="group_id[<? echo $s['id']; ?>]">
            <option value="">None</option>
            <?php if ($groups) { ?>
            <? foreach ($groups as $g) { ?>
            <option value="<?php echo $g['id']; ?>" <?php if ($s['group_id'] == $g['id']) echo 'selected';  ?>>
              <?php echo $g['name']; ?></option>
            <? } ?>
            <? } ?>
          </select>
          <? //echo $s['group']; 
              ?>
        </td>
        <td>
          <button type="submit" name="update" value="<? echo $s['id']; ?>">Update</button>
          <button type="submit" name="delete" value="<? echo $s['id']; ?>">Delete</button>
        </td>
      </tr>
      <? } ?>
    </table>
  </form>
  <? } ?>
</body>

</html>