<?
	class SubjectsController{
		public $model;	
		
		public function __construct(){
			$this->model = new SubjectsModel; 
		}
		
		public function redirect($url){
			if($url) header('Location: '.$url);
		}
		
		public function index(){
			$subjects = $this->model->getSubjectsFromDB();
			include 'views/subjects.php';	
		}	
		
		public function addSubject(){
			if($_POST['name']){
				$this->model->addSubjectToDB();			
			}
			$this->redirect("/index.php/subjects");
		}
		
		public function actions(){
			if($_POST['delete']) $this->model->deleteSubjectFromDB();
			if($_POST['update']) $this->model->updateSubject();			
			$this->redirect("/index.php/subjects");
		}
		
	}
?>