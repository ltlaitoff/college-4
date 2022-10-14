<form action="index.php" method="POST">
  <label>Имя, фамилия</label>
  <input name="name">
  <label>Возраст</label>
  <input name="age" type="number">
  <button type="submit">SEND</button>
</form>
<?php
  if(!empty($message)) {
    echo $message;
  }

  if(isset($_COOKIE['students'])){
?>

<table border=1>
  <tr>
    <th>Ім'я і прізвище</th>
    <th>Вік</th>
  </tr>

  <?php
    $students = unserialize($_COOKIE['students']);
    for($i=0;$i<count($students);$i++){
  ?>
  <tr>
    <td>
      <?php echo $students[$i]['name'];?>
    </td>
    <td>
      <?php echo $students[$i]['age'];?>
    </td>
  </tr>
  <?php 
    }}
  ?>

</table>