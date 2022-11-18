<?php
define('SITE_ROOT_FILES', realpath(__DIR__ . '/..'));

class files
{
	public $files;
	public $message;

	function __construct()
	{
		$this->files = scandir(SITE_ROOT_FILES . "/files");
		if (isset($_GET['message'])) {
			$this->message = $_GET['message'];
		}
	}

	function redirect($url, $messageProp = null)
	{
		if ($url && $messageProp) {
			header('Location:' . $url . '?message=' . $messageProp);
			return;
		}

		if ($url && !$messageProp) {
			header('Location:' . $url);
			return;
		}
	}

	function counter()
	{

		$filename = "./counter.txt";

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
			$this->redirect(SITE_ROOT);
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
			$this->redirect(SITE_ROOT, "Файл существует");
		} else {
			$this->redirect(SITE_ROOT, "Файл не существует");
		}
	}

	function delete()
	{
		unlink("./files/" . $_POST['delete']);
		$this->redirect(SITE_ROOT);
	}

	function checkOnMyFileIsset()
	{
		if (isset($_FILES['myfile'])) {
			$this->upload();
			header("location:index.php");
		}
	}
	function checkOnPostDelete()
	{
		if (isset($_POST['delete'])) {
			$this->delete();
			header("location:index.php");
		}
	}

	function checkOnPostSearchname()
	{
		if (isset($_POST['searchname'])) {
			$this->search();
		}
	}
}