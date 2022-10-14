<form action="index.php" method="POST">
  <label>Логин</label>
  <input name="login" type="text">
  <label>Пароль</label>
  <input name="password" type="password">
  <button type="submit">SEND</button>
</form>

<?php
  if(!empty($message)) {
    echo $message;
  }
?>