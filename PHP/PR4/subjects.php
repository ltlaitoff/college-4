<?php
  class Subjects {
    private $subjectsArray = array(
      "Конструювання програмного забезпечення",
      "Комп'ютерні мережі",
      "Дискретна математика",
      "Фізика",
      "Фізкультура",
      "Історія"
    );

    public $students = "Студент1, Студент2, Студент3, Студент4, Студент5";
    
    public function changeArray($key, $value) {
      $this->subjectsArray[array_search($key, $this->subjectsArray)] = $value;
    }
    
    public function changeArray2($inputKey, $inputValue, $num) {
      $count = 0;
      
      foreach($this->subjectsArray as $forKey => $forValue) {
        if($forValue == $inputKey) {
          $count++;
        }
        
        if($count == $num) {
          $newValue = str_replace($inputKey, $inputValue, $forValue);
          
          $this->subjectsArray[$forKey] = $newValue;
        }
      }
    }

    public function sort() {
      asort($this->subjectsArray);
    }

    public function exploding($string) {
      return explode(', ', $string);
    }

    public function imploding($array) {
      return implode(', ', $array);
    }

    public function expansion() {
      foreach($this->subjectsArray as $index=>$value) {
        $this->subjectsArray[$index] = array(
          "name" => $value,
          "hours" => rand(10, 50)
        );
      }
    }
    
  
    public function showSubjectsArray($title = "", $array = null) {
      echo "<hr>";
      echo "<h3>".$title."</h3>";
      
      $arrayForOutput = $array == null ? $this->subjectsArray : $array;

      foreach($arrayForOutput as $subject) {
        echo $subject."<br>";
      }
      
      echo "<hr>";
    }
    
    public function show_unique() {
      $subjectsArray = array_unique($this->subjectsArray);
      $this->showSubjectsArray('unique', $subjectsArray);
    }

    public function showAsTable($title = "", $table = null) {
      echo "<hr>";
      echo "<h3>".$title."</h3>";
      
      $table = $table == null ? $this->subjectsArray : $table;

      echo "<table>";
      echo "<tr> <th>Subject</th> <th>Hours</th> </tr>";
      
      foreach($table as $subject) {
        echo "<tr> <td>".$subject["name"]."</td> <td>".$subject["hours"]."</td> </tr>";
      }

      echo "</table>";
      echo "<hr>";
    }

    public function show_splitted_array() {
      $splitted_array = array_chunk($this->subjectsArray, 3);
      
      $this->showAsTable("splitted: Array0", $splitted_array[0]);
      $this->showAsTable("splitted: Array1", $splitted_array[1]);
    }
  }
?>