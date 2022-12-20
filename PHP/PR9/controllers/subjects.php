<?
class SubjectsController
{
	public $model;

	public function __construct()
	{
		$this->model = new SubjectsModel;
	}

	public function redirect($url)
	{
		if ($url) header('Location: ' . $url);
	}

	public function index()
	{
		$subjects = $this->model->getSubjectsFromDB();
		include 'views/subjects.php';
	}

	public function getSubjects()
	{
		$data['subjects'] = $this->model->getSubjectsFromDB();

		die(json_encode($data));
	}

	public function addSubject()
	{
		if ($_POST['name']) {
			$this->model->addSubjectToDB();
			die(json_encode($_POST));
		}

		die(json_encode(true));
	}

	public function actions()
	{
		if ($_POST['delete']) $this->model->deleteSubjectFromDB();
		if ($_POST['update']) $this->model->updateSubject();
		die(json_encode(true));
	}
}