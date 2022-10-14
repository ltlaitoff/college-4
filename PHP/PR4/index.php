<?php
  include('subjects.php');
  $subjects = new Subjects();
?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Practice Work 4</title>
</head>

<body>
  <div class="container">
    <?php
      $subjects->showSubjectsArray('5.');

      $subjects->changeArray("Фізкультура", "Історія");
      $subjects->showSubjectsArray('8.');

      $subjects->show_unique();

      $subjects->changeArray2("Історія", "Фізкультура", 2);
      $subjects->showSubjectsArray('10.');

      $subjects->sort();
      $subjects->showSubjectsArray('12.');

      $subjects->expansion();
      $subjects->showAsTable("13.");
      
      $subjects->show_splitted_array();
      
      echo "defaultArr: ".$subjects->students;
      echo "<br>";
      $arr = $subjects->exploding($subjects->students);
      
      echo "explode: ";
      print_r($arr);
      echo "<br>";

      echo "implode: ";
      print($subjects->imploding($arr));
  ?>
  </div>
</body>

</html>