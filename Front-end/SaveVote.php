
<html>
<body>


<?php
// open the file "demosaved.csv" for writing
$file = fopen('demosaved.csv', 'a');
$emoji =  htmlspecialchars($_GET["emoji"];
$comment =  htmlspecialchars($_GET["comment"]
 
// save the column headers
fputcsv($file, array($emoji, $comment));
 
// Close the file
fclose($file);

?>


Your emoji is <?php echo $"emoji"; ?><br>
Your comment is: <?php echo $"comment"; ?><br>
<br>
Go back to the <a href="studentvotepage.html">Vote</a> page

</body>
</html>

