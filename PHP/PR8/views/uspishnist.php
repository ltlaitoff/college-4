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

  <form action="/index.php/uspishnist/addUspishnist" method="POST">
    <input type="number" name="mark" placeholder="Mark" required /><br>
    <select name="s_id">
      <option value="">None</option>
      <?php if ($students) { ?>
      <? foreach ($students as $s) { ?>
      <option value="<?php echo $s['id']; ?>"><?php echo $s['name']; ?></option>
      <? } ?>
      <? } ?>
    </select>

    <br>

    <select name="p_id">
      <option value="">None</option>
      <?php if ($subjects) { ?>
      <? foreach ($subjects as $s) { ?>
      <option value="<?php echo $s['id']; ?>"><?php echo $s['name']; ?></option>
      <? } ?>
      <? } ?>
    </select>

    <br>
    <input type="submit" value="Отправить" />
  </form>

  <hr>
  <?
  if ($uspishnist) { ?>
  <form method="POST" action="/index.php/uspishnist/actions">
    <table>
      <tr>
        <th>Оцінка</th>
        <th>Студент</th>
        <th>Група</th>
        <th>Дія</th>
      </tr>
      <? foreach ($uspishnist as $u) { ?>
      <tr>
        <td> <input type="number" name="mark[<? echo $u['id']; ?>]" placeholder="Mark" required
            value="<? echo $u['mark']; ?>"> </td>
        <td>
          <select name="s_id[<?php echo $u['id']; ?>]">
            <option value="">None</option>
            <?php if ($students) { ?>
            <? foreach ($students as $s) { ?>
            <option value="<?php echo $s['id']; ?>" <?php if ($u['s_id'] == $s['id']) echo 'selected';  ?>>
              <?php echo $s['name']; ?></option>
            <? } ?>
            <? } ?>
          </select>
        </td>
        <td>
          <select name="p_id[<?php echo $u['id']; ?>]">
            <option value="">None</option>
            <?php if ($subjects) { ?>
            <? foreach ($subjects as $s) { ?>
            <option value="<?php echo $s['id']; ?>" <?php if ($u['p_id'] == $s['id']) echo 'selected';  ?>>
              <?php echo $s['name']; ?></option>
            <? } ?>
            <? } ?>
          </select>
        </td>
        <td>
          <button type="submit" name="update" value="<? echo $u['id']; ?>">Update</button>
          <button type="submit" name="delete" value="<? echo $u['id']; ?>">Delete</button>
        </td>
      </tr>
      <? } ?>
    </table>
  </form>
  <? } ?>
</body>

</html>