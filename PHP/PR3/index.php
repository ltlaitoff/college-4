<?php
  session_start();
  include 'students.php';
  global $message;

  $s = new Students();
  
  if(isset($_POST['login']) && isset($_POST['password'])) {
    $s->login();
  }
  
  if(isset($_POST['name']) && isset($_POST['age'])) {
    $s->addNew(); 
  }
?>

<html>
<header>

  <body>
    <?php
      if(isset($_SESSION['login'])) {
        include 'form.php';
      } else {
        include 'login.php';
      }
    ?>
  </body>
</header>

</html>