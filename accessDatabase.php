<html>
	<head><title>Database Access</title></head>
	<body>
		<?php
			$conn_string = "host=localhost port=5432 dbname=ESLAB user=pi password=448346";

			$db = pg_connect($conn_string);
			
			if(!$db){
				echo "Error : Unable to open database\n";
			} else {
				echo "Opened database successfully\n";
				echo "<br />\n";
			}	

			$result = pg_query($db, 'SELECT * FROM public."Student"');
			if(!$result){
				echo "An error occurred.\n";
				exit;
			}

			$resultArr = pg_fetch_all($result);

			echo '<table>
					<tr>
						<td>ID</td>
						<td>Name</td>
						<td>PhoneNumber</td>
						<td>AdvisorID</td>
						<td>DepartmentID</td>
					<tr>';

			
			foreach($resultArr as $array){
				echo '<tr>
						<td>' . $array['ID'] . '</td>
						<td>' . $array['Name'] . '</td>
						<td>' . $array['PhoneNumber'] . '</td>
						<td>' . $array['AdvisorID'] . '</td>
						<td>' . $array['DepartmentID'] . '</td>
					</tr>';
			}
			echo '</table>';

		?>
	</body>
</html>
