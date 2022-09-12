<?php 
class Students {
    private array $students;

    public function __construct(Student ...$studentsArray) {
      $this->students = $studentsArray;
    }

    public function addStudent(Student $newStudent) {
      array_push($this->students, $newStudent);
    }

    public function getStudents() {
      return $this->students;
    } 

    public function changeStudentsAge(): void {
      foreach ($this->students as $student) {
        $currentStudentAge = $student->getAge();

        if ($currentStudentAge % 3 === 0) {
          $student->setAge(8);
          continue;
        }

        if ($currentStudentAge % 2 === 0) {
          $student->setAge(7);
          continue;
        }

        $student->setAge(9);
      }
    }

    public function getTotalStudentsAge(): int {
      $totalAge = 0;

      foreach ($this->students as $student) {
        $totalAge += $student->getAge();
      }

      return $totalAge;
    }
  }
?>