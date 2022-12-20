<!DOCTYPE html>
<html lang="en">
<head>
 	<meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PR9</title>
</head>
<body>
	<ul>
		<li><a href="/">Students</a></li>
		<li><a href="/index.php/subjects">Subjects</a></li>
		<li><a href="/index.php/uspishnist">Uspishnist</a></li>
	</ul>
    <form action="/index.php/subjects/addSubject" method="POST"> 
        <input type = "text" name = "name" placeholder="Name" required /><br>
		<!-- <input type = "number" name = "group_id" placeholder="Group id" min="1" max="2" required /><br> -->
		
		<br>
        <input type = "submit" value = "Отправить" />
    </form>
	
	<hr>
	<? 
	if($subjects){?>
	<form method="POST" action="/index.php/subjects/actions">
		<table>
			<tr>
				<th>Ім'я</th> 

				<th>Дія</th>
			</tr>
			<? foreach($subjects as $s){ ?>                                                                                                                                  
					<tr>
						<td> <input type = "text" name = "name[<? echo $s['id']; ?>]" placeholder="Name" required value="<? echo $s['name']; ?>"> </td> 
						
						<td> 
							<button type="submit" name="update" value="<? echo $s['id']; ?>">Update</button>
							<button type="submit" name="delete" value="<? echo $s['id']; ?>">Delete</button>  
						</td>
					</tr>
			<? } ?>
		</table>
	</form>
	<? } ?>
</body>
</html>