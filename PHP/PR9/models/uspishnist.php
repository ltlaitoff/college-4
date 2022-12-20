<?
class UspishnistModel extends Model
{

	public function getUspishnistFromDB()
	{
		$q = "SELECT * FROM uspishnist";
		return $this->db_select_array($q);
	}

	public function getStudents()
	{
		$q = "SELECT * FROM students";
		return $this->db_select_array($q);
	}

	public function getSubjects()
	{
		$q = "SELECT * FROM subjects";
		return $this->db_select_array($q);
	}

	public function addUspishnistToDB()
	{
		$q = $this->insert_db_query($_POST, 'uspishnist');
		$this->db_query($q);
	}

	public function deleteUspishnistFromDB()
	{
		$q = "DELETE FROM uspishnist WHERE id = " . $_POST['delete'];
		$this->db_query($q);
	}

	public function updateUspishnist()
	{
		$q = "UPDATE uspishnist SET s_id='" . $_POST['s_id'] . "', p_id='" . $_POST['p_id'] . "', mark='" . $_POST['mark'] . "' WHERE id = " . $_POST['update'];
		$this->db_query($q);
	}
}