<?
class UspishnistController
{
	public $model;

	public function __construct()
	{
		$this->model = new UspishnistModel;
	}

	public function redirect($url)
	{
		if ($url) header('Location: ' . $url);
	}

	public function index()
	{
		$uspishnist = $this->model->getUspishnistFromDB();
		$students = $this->model->getStudents();
		$subjects = $this->model->getSubjects();
		include 'views/uspishnist.php';
	}

	public function getUspishnist()
	{
		$data['uspishnist'] = $this->model->getUspishnistFromDB();
		$data['students'] = $this->model->getStudents();
		$data['subjects'] = $this->model->getSubjects();

		die(json_encode($data));
	}

	public function addUspishnist()
	{
		if ($_POST) {
			$this->model->addUspishnistToDB();
			die(json_encode(true));
		}

		die(json_encode(false));
		// $this->redirect("/index.php/uspishnist");
	}

	public function actions()
	{
		if ($_POST['delete']) $this->model->deleteUspishnistFromDB();
		if ($_POST['update']) $this->model->updateUspishnist();
		// $this->redirect("/index.php/uspishnist");
	}
}