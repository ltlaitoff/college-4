<?php
class Students{

function redirect($url){
	header('Location:'.$url);
}

function login(){
	global $message;
	if($_POST['login']=='user' && $_POST['password']==123) {
		$_SESSION['login']=true;
	} else {
		$message = 'Not valid pass or login';
	}
}
function logout(){
	unset($_SESSION['login']);
	session_destroy();
	$this->redirect('index.php');
}

function addNew(){
	global $message;

  $message = '';

	if(
    !isset($_POST['name'])  || 
    empty($_POST['name']) ||
    !is_string($_POST['name']) || 
    count(str_word_count($_POST['name'], 1)) != 2 
    ){
		$message = 'Incorrect name';
	}
  
	if(!isset($_POST['age'])  || empty($_POST['age']) || !is_numeric($_POST['age'])){
		$message = 'Incorrect age';
	}

	if(empty($message)){
		$students = array();
		if(isset($_COOKIE['students']) && !empty($_COOKIE['students'])){
			$students = unserialize($_COOKIE['students']);
		}
		$name = $_POST['name'];
		$age = $_POST['age'];
		$student = array(
			"name"=>$name,
			"age"=>$age,
		);
		array_push($students,$student);
		setcookie('students', serialize($students),time()+3600);
		$this->redirect('index.php');
		}
		
		$this->logout();
	}

}