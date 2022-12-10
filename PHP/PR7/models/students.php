<?php

class StudentsModel extends Model
{
    public function getStudentsFromDB()
    {
        $query = "SELECT s.*, g.name as `group` FROM students as s
        LEFT JOIN groups as g ON (g.id = s.group_id)";

        return $this->db_select_array($query);
    }

    public function addStudentToDB()
    {
        $query = $this->insert_db_query($_POST, 'students');

        $this->db_query($query);
    }

    public function deleteStudentFromDB()
    {
        $query = "DELETE FROM students WHERE id = " . $_POST['delete'];

        $this->db_query($query);
    }
}