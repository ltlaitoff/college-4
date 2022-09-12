<?php
include 'Student.php';
include 'Students.php';

define('TITLE', 'PR_2');
define('NAME', 'Schedrovskiy Ivan');

$myInfo = array('Age' => 18, 'Place of Birth' => 'Vilnyansk', 'Telephone' => 88005553535);

$studentsHeaders = array('Name', 'Second Name', 'Age', 'Place of Birth', 'Telephone');
$students = new Students(
  new Student('Name1', 'SName 1', 16, 'ZP', 123),
  new Student('Name2', 'SName 2', 18, 'ZP', 1234),
  new Student('Name3', 'SName 3', 19, 'ZP', 12345),
  new Student('Name4', 'SName 4', 18, 'ZP', 123456),
  new Student('Name5', 'SName 5', 19, 'ZP', 1234567),
);

$students->addStudent(new Student('Name6', 'SName 6', 20, 'ZP', 12345678));

$students->changeStudentsAge();
$totalStudentAge = $students->getTotalStudentsAge()
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

    <?php foreach ($students->getStudents() as $student) { ?>
      <tr>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student->getName(); ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student->getSurname(); ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student->getAge(); ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student->getPlaceOfBirth(); ?></td>
        <td class="<?php echo $tableClassCell ?>"><?php echo $student->getTelephone(); ?></td>
      </tr>
    <?php } ?>
  </table>
  <div>Загальний вік сутдентів: <?php echo $totalStudentAge; ?></div>
  

</body>

</html>