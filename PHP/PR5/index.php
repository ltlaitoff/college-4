<?php
include('files.php');
$file = new Files();

if (isset($_FILES['myfile'])) {
  $file->upload();
  header("location:index.php");
}

if (isset($_POST['delete'])) {
  $file->delete();
  header("location:index.php");
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PR_5</title>
</head>

<body>
  <?php $file->counter(); ?>
  <form enctype="multipart/form-data" method="post">
    <input type="hidden" name="MAX_FILE_SIZE value=" 3000">
    <input type="file" name="myfile" /> <br>
    <input type="submit" value="Отправить" />
  </form>

  <hr>

  <form enctype="multipart/form-data" method="post">
    <input type="text" name="searchname" /> <br>
    <input type="submit" value="Найти" />
  </form>

  <?php
  if (isset($_POST['searchname'])) {
    $file->search();
    // header("location:index.php");
  }
  ?>

  <hr>

  <?php if (count($file->files) > 2) { ?>
  <form method="POST">
    <table>
      <tr>
        <th>Имя</th>
        <th>Удалить</th>
      </tr>

      <?php
        foreach ($file->files as $s) {
          if ($s != '.' and $s != '..') {
        ?>
      <tr>
        <td><?php echo $s; ?></td>
        <td>
          <button type="submit" name="delete" value="<?php echo $s ?>">Удалить</button>
        </td>
      </tr>
      <?php
          }
        }
        ?>
    </table>
  </form>
  <?php } ?>
</body>

</html>