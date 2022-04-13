<?php session_start();  ?>
<?php include('header.php'); ?>





	<!-- récupération des informations de connexion -->
	<div class="login" style="background-color:#fff;">
		<h3 class="text-center" style="background-color:#272327;color: #fff;">Connexion Patient</h3>
			<div class="formstyle" style="float: right;padding:20px;border: 1px solid lightgrey;margin-right:415px; margin-bottom:120px;background-color:#f3f3f8;color:#141313;">
				<form action="" method="post" class="text-center form-group">
					<label>
						 <input type="email" name="email"  placeholder="email" required>
					</label><br><br>
					<label>
						 <input type="password" name="Mdp"  placeholder="mot de passe" required>
					</label><br><br>
					<button name="submit" type="submit" style="margin-left: -26px;width: 85px;border-radius: 3px;">Connexion</button> <br>

					<span style="color:#000;">Vous n'avez pas de compte? </span><a href="patient_inscription.php" title="create a account" target="" style="color:#000;">&nbsp;S'inscrir</a> <br>


					<!-- validation du login -->
			<?php 
					$_SESSION['patient']="";
							
							include('config.php');
							if(isset($_POST["submit"])){


							$sql= "SELECT * FROM patient WHERE email= '" . $_POST["email"]."' AND Mdp= '" . $_POST["Mdp"]."'";

							$result = $conn->query($sql);

									if ($result->num_rows > 0) {
											$_SESSION["email"]= $_POST["email"];
											$_SESSION['patient']= "yes";
										    echo "<script>location.replace('patient/compte_patient.php');</script>";
												
										} else {
										    echo "<span style='color:red;'>Invalid username or password</span>";
										}
						$conn->close();		
					}
					
 			?>
		


				</form> <br>&nbsp;&nbsp;&nbsp;
				
				<br>

				
		
				
			
		
	</div>
	
	
</div>
	
 <?php include('footer.php'); ?>


	
	</div>




	<script src="js/bootstrap.min.js"></script>


 
			



	
</body>
</html>

