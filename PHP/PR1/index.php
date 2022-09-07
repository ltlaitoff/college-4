<?php
define('TITLE', 'PR_1');
define('NAME', 'Schedrovskiy Ivan');

$myInfo = array('Age' => 18, 'Place of Birth' => 'Vilnyansk', 'Telephone' => 88005553535);

$studentsConstantName = 'Name';
$studentsConstantSecondName = 'Second Name';
$studentsConstantAge = 'Age';
$studentsConstantPlaceOfBirth = 'Place of Birth';
$studentsConstantTelephone = 'Telephone';

$studentsHeaders = array($studentsConstantName, $studentsConstantSecondName, $studentsConstantAge, $studentsConstantPlaceOfBirth, $studentsConstantTelephone);
$students = array(
  0 => array($studentsConstantName => 'Name1', $studentsConstantSecondName => 'SName 1', $studentsConstantAge => 18, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 123),
  1 => array($studentsConstantName => 'Name2', $studentsConstantSecondName => 'SName 2', $studentsConstantAge => 19, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 1234),
  2 => array($studentsConstantName => 'Name3', $studentsConstantSecondName => 'SName 3', $studentsConstantAge => 18, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 12345),
  3 => array($studentsConstantName => 'Name4', $studentsConstantSecondName => 'SName 4', $studentsConstantAge => 19, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 123456),
  4 => array($studentsConstantName => 'Name5', $studentsConstantSecondName => 'SName 5', $studentsConstantAge => 18, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 1234567),
  5 => array($studentsConstantName => 'Name6', $studentsConstantSecondName => 'SName 6', $studentsConstantAge => 19, $studentsConstantPlaceOfBirth => 'ZP', $studentsConstantTelephone => 12345678),
);

?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title><?php echo TITLE ?></title>
  <link rel="stylesheet" href="./style/style.css">
</head>

<body>
  <h1 class="title"><?php echo NAME; ?></h1>
  <div class="photo">?</div>
  <ul class="list">
    <?php foreach ($myInfo as $key => $value) { ?>
      <li class="list-item"><?php echo $key . ': ' . $value; ?></li>
    <?php }; ?>
  </ul>

  <?php 
    $tableClass = 'students-table';
    $tableClassHeadCell = 'students-table-head-cell';
    $tableClassCell = 'students-table-cell';
  ?>
  <table class="<?php echo $tableClass ?>">
    <tr>
      <?php foreach ($studentsHeaders as $headElement) { ?>
        <th class="<?php echo $tableClassHeadCell ?>"><?php echo $headElement; ?></th>
      <?php } ?>
    </tr>

    <?php foreach ($students as $student) { ?>
      <tr>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student[$studentsConstantName]; ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student[$studentsConstantSecondName]; ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student[$studentsConstantAge]; ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student[$studentsConstantPlaceOfBirth]; ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student[$studentsConstantTelephone]; ?></td>
      </tr>
    <?php } ?>
  </table>

</body>

</html>