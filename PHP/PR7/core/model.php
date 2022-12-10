<?php
class Model
{
	public $link;
	public function __construct()
	{
		$this->link = mysqli_connect(DBHOST, DBLOGIN, DBPASSWORD, DBNAME) or die('error connection');

		//mysqli_select_db($this->link, DBNAME) or die('error db');
		mysqli_query($this->link, "SET character_set_results = 'utf8', character_set_client = 'utf8', character_set_connection = 'utf8', character_set_database = 'utf8', character_set_server = 'utf8'");
	}

	public function db_select_array($query)
	{
		$mysql_query = mysqli_query($this->link, $query);

		$arr = array();
		while ($row = mysqli_fetch_array($mysql_query)) {
			$arr[] = $row;
		}

		return $arr;
	}

	public function db_select_row($query)
	{
		$mysql_query = mysqli_query($this->link, $query);

		$arr = array();
		while ($row = mysqli_fetch_array($mysql_query, MYSQLI_ASSOC)) {
			$arr = $row;
		}

		return $arr;
	}

	public function db_query($query)
	{
		if (mysqli_query($this->link, $query) == true);
	}

	public function getRows($table)
	{
		//$link = mysqli_connect(DBHOST, DBLOGIN, DBPASSWORD);
		$columns = $this->db_select_array("SHOW columns FROM $table");
		$return = array();
		if ($columns) {
			foreach ($columns as $c) {
				$return[$c['Field']] = $c;
			}
		}
		//die(var_dump($columns));
		//$columns = mysql_num_fields($fields);

		/*$return = array();
		foreach ($columns as $column) {
			if(mysql_field_name($fields, $i) != 'id'){
				$return[mysql_field_name($fields, $i)]['type'] = mysql_field_type($fields, $i);
			}
		}	
		die(var_dump($return));*/
		return $return;
	}

	public function insert_db_query($data, $table)
	{
		if (!empty($data)) {

			$ar_is_row = $this->getRows($table);

			$ar_is_row2 = array();
			foreach ($data as $n => $a) {
				if (isset($ar_is_row[$n])) {
					$ar_is_row2[$n] = $a;

					if (isset($ar_is_row[$n]['type']) && $ar_is_row[$n]['type'] == 'int') {
						$ar_is_row2[$n] = (int)$a;
					}
				}
			}

			$str = 'INSERT INTO ' . $table . ' SET ';
			$i = 0;
			$data = $ar_is_row2;
			foreach ($data as $n => $a) {
				if ($i == 0) {
					if (gettype($a) == 'integer') {
						$str .= $n . "=" . $a;
					}

					if (gettype($a) == 'string') {
						$str .= $n . "='" . $a . "'";
					}
					if (gettype($a) == 'array') {
						$str .= $n . "='" . serialize($a) . "'";
					}
				} else {
					if (gettype($a) == 'integer') {
						$str .= ', ' . $n . "=" . $a;
					}
					if (gettype($a) == 'string') {
						$str .= ', ' . $n . "='" . $a . "'";
					}
					if (gettype($a) == 'array') {
						$str .= ', ' . $n . "='" . serialize($a) . "'";
					}
				}

				$i++;
			}
			//die(var_dump($str));
			return $str;
		}
	}

	public function update_db_query($data, $table, $where)
	{
		if (!empty($data)) {

			$ar_is_row = $this->getRows($table);

			$ar_is_row2 = array();
			foreach ($data as $n => $a) {
				if (isset($ar_is_row[$n])) {
					if ($ar_is_row[$n]['type'] == 'int') {
						$ar_is_row2[$n] = (int)$a;
					} else {
						$ar_is_row2[$n] = $a;
					}
				}
			}
			//die(var_dump($ar_is_row2));
			$str = 'UPDATE ' . $table . ' SET ';
			$i = 0;
			$data = $ar_is_row2;
			foreach ($data as $n => $a) {
				if ($i == 0) {
					if (gettype($a) == 'integer') {
						$str .= $n . "=" . $a;
					}

					if (gettype($a) == 'string') {
						$str .= $n . "='" . $a . "'";
					}
					if (gettype($a) == 'array') {
						$str .= $n . "='" . serialize($a) . "'";
					}
				} else {
					if (gettype($a) == 'integer') {
						$str .= ', ' . $n . "=" . $a;
					}
					if (gettype($a) == 'string') {
						$str .= ', ' . $n . "='" . $a . "'";
					}
					if (gettype($a) == 'array') {
						$str .= ', ' . $n . "='" . serialize($a) . "'";
					}
				}

				$i++;
			}
			if ($where) {
				$str .= ' WHERE ' . $where;
			}
			//die(var_dump($str));
			return $str;
		}
	}

	public function kiloformat($data)
	{
		if ($data > 1000) {
			$data = $data / 1000;
			$data = $data . 'K';
		}
		if (!$data) {
			$data = 0;
		}
		return $data;
	}

	public function crypt($d)
	{
		if ($d) {
			// Store the cipher method 
			$ciphering = "AES-128-CTR";

			// Use OpenSSl Encryption method 
			$iv_length = openssl_cipher_iv_length($ciphering);
			$options = 0;

			// Non-NULL Initialization Vector for encryption 
			$encryption_iv = '12434567891011121';

			// Store the encryption key 
			$encryption_key = "Basok";

			// Use openssl_encrypt() function to encrypt the data 
			$encryption = openssl_encrypt(
				$d,
				$ciphering,
				$encryption_key,
				$options,
				$encryption_iv
			);

			return $encryption;
		}
	}

	public function decrypt($d)
	{
		if ($d) {

			$ciphering = "AES-128-CTR";
			// Non-NULL Initialization Vector for decryption 
			$decryption_iv = '12434567891011121';
			$options = 0;
			// Store the decryption key 
			$decryption_key = "Basok";

			// Use openssl_decrypt() function to decrypt the data 
			$decryption = openssl_decrypt(
				$d,
				$ciphering,
				$decryption_key,
				$options,
				$decryption_iv
			);
			return $decryption;
			///$calcmac = hash_hmac('sha256', $ciphertext_raw, $key, $as_binary=true);		
		}
	}
}