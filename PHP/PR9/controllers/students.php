<?
class StudentsController
{
	public $model;

	public function __construct()
	{
		$this->model = new StudentsModel;
	}

	public function redirect($url)
	{
		if ($url) header('Location: ' . $url);
	}

	public function index()
	{
		include 'views/default.php';
	}

	public function getData()
	{
		$data['students'] = $this->model->getStudentsFromDB();
		$data['groups'] = $this->model->getGroups();

		die(json_encode($data));
	}

	public function addStudent()
	{
		if ($_POST['name'] && $_POST['group_id']) {
			$this->model->addStudentToDB();
		}
		die(json_encode(true));
	}

	public function actions()
	{
		if ($_POST['delete']) $this->model->deleteStudentFromDB();
		if ($_POST['update']) $this->model->updateStudent();
		die(json_encode(true));
	}
}