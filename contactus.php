<?php include('header.php'); ?>




	<!-- this is for donor registraton -->
	<div class="contactus"  style="background-color:#fff;">
	<h3 class="text-center" style="background-color:#272327;color: #fff;">Écrivez-nous</h3>
			<div class="formstyle" style="float: right;padding:20px;border: 1px solid lightgrey;margin-right:415px; margin-bottom:30px;background-color:#f3f3f8;color:#141313;">
				<form action="" method="post" class="text-center form-group">
				        <label>
						        Prénom: <input type="text" name="firstname"  placeholder="prénom" required>
					    </label><br><br>
					    <label>
						        Nom<input type="text" name="lastname"  placeholder="nom" required>
					    </label><br><br>	

						<label>
								Email: <input type="email" name="email"  value="" placeholder="email" required>
						</label><br><br>
						<label>
								Votre Commentaire: <textarea name="comment" placeholder="commentaire" id="" cols="30" rows="4" required></textarea> 
						</label><br><br>
								
						<input type="submit" value="Envoyer" name="submit" style="margin-top: 10px;margin-right:5px;border-radius: 2px;"/>
						
 
					</form>
			</div>

          
 		</div>

	</div>
	
	

	
 <?php include('footer.php'); ?>


	
	</div><!--  containerFluid Ends -->




	<script src="js/bootstrap.min.js"></script>


 
<!-- contact information inserting -->
					<?php

						include('config.php');
						if(isset($_POST['submit'])){
							

							$sql = "INSERT INTO contact (firstname, lastname,email,comment)
							VALUES ('" . $_POST["firstname"] ."','" . $_POST["lastname"] . "','" . $_POST["email"] . "','" . $_POST["comment"] . "' )";

							if ($conn->query($sql) === TRUE) {
							    echo "<script>location.replace('success.php');</script>";
							} else {
							    echo "<script>alert('Une erreur s'est produite')<script>" . $sql . "<br>" . $conn->error;
							}

							$conn->close();
						}
					?> 



	
</body>
</html>









