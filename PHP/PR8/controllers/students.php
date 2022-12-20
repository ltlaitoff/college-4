<?
	class StudentsController{
		public $model;	
		
		public function __construct(){
			$this->model = new StudentsModel; 
		}
		
		public function redirect($url){
			if($url) header('Location: '.$url);
		}
		
		public function index(){
			$groups = $this->model->getGroups();
			$students = $this->model->getStudentsFromDB();
			include 'views/default.php';	
		}	
		
		public function addStudent(){
			if($_POST['name'] && $_POST['group_id']){
				$this->model->addStudentToDB();			
			}
			$this->redirect('/');
		}
		
		public function actions(){
			if($_POST['delete']) $this->model->deleteStudentFromDB();
			if($_POST['update']) $this->model->updateStudent();			
			$this->redirect('/');
		}
		
	}