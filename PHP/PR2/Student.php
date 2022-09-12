<?php 
  class Student {
    private string $name;
    private string $surname;
    private int $age;
    private string $placeOfBirth;
    private int $telephone;

    public function __construct(string $name,string $surname, int $age, string $placeOfBirth, int $telephone) {
      $this->name = $name;
      $this->surname = $surname;
      $this->age = $age;
      $this->placeOfBirth = $placeOfBirth;
      $this->telephone = $telephone;
    }

    public function getName() {
      return $this->name;
    }

    public function setName($newName) {
      $this->name = $newName;
    }

    public function getSurname() {
      return $this->surname;
    }

    public function setSurname($newSurname) {
      $this->surname = $newSurname;
    }

    public function getAge() {
      return $this->age;
    }

    public function setAge($age) {
      $this->age = $age;
    }

    public function getPlaceOfBirth() {
      return $this->placeOfBirth;
    }

    public function setPlaceOfBirth($newPlaceOfBirth) {
      $this->PlaceOfBirth = $newPlaceOfBirth;
    }

    public function getTelephone() {
      return $this->telephone;
    }

    public function setTelephone($newTelephone) {
      $this->telephone = $newTelephone;
    }
  }
?>