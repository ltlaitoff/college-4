<?php
define('SITE_ROOT', __DIR__);

class Files
{
	public $files;

	function __construct()
	{
		$this->files = scandir(SITE_ROOT . "/files");
	}

	function redirect($url)
	{
		header('Location:' . $url);
	}

	function counter()
	{

		$filename = "counter.txt";

		if (file_exists($filename)) {
			$h = fopen($filename, "r+");
			$Content = fread($h, filesize($filename));

			fclose($h);
			$text = $Content + 1;
		} else {
			$text = 1;
		}

		$h = fopen($filename, "w");
		if (fwrite($h, $text)) {
			echo "Вы $text посетитель";
		} else {
			echo "ошибка";
		}

		fclose($h);
		echo "<hr>";
	}
	function upload()
	{
		$uploaddir = './files/';

		$dest = $uploaddir . $_FILES['myfile']['name'];
		if (move_uploaded_file($_FILES['myfile']['tmp_name'], $dest)) {
			$this->redirect('/');
		} else {
			return "error <br>";
		}
	}
	function search()
	{
		$folder = "./files/";
		$searchname = $_POST['searchname'];
		$file = $folder . $searchname;

		if (file_exists($file)) {
			echo "Файл существует";
		} else {
			echo "Файл не существует";
		}
	}

	function delete()
	{
		unlink("./files/" . $_POST['delete']);
		$this->redirect("/");
	}
}