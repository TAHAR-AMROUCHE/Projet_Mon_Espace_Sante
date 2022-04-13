<?php include('header.php'); ?>





	<!-- this is for donor registraton -->
	<div class="recipient_reg" style="background-color:#272327;">
		<h3 class="text-center" style="background-color:#272327;color: #fff;">Inscription</h3>

		<div class="formstyle" style="float: right;padding:25px;border: 1px solid lightgrey;margin-right:650px; margin-bottom:30px;background-color:#f3f3f8;color:#141313;">
		<form enctype="multipart/form-data" method="post" class="text-center">
			 <div class="col-md-12">
				  
			        <label>
						Votre NIR: <input type="text" name="NIR" value="" placeholder="NIR" required>
					</label><br><br>
					<label>
						Votre nom: <input type="text" name="nom" value="" placeholder="Nom" required>
					</label><br><br>
					<label>
						Votre prénom: <input type="text" name="prenom" value="" placeholder="Prénom" required>
					</label><br><br>

					<label>
						Age: <input type="number" name="age"  placeholder="age" pattern="[0-9]{2,2}" title="please enter only  numbers between 2 to 2 for age"/>
					</label><br><br>
					<label>
						Mobile: <input type="number" name="contact"  placeholder="contact" required="required" pattern="[0-9]{10,11}" title="please enter only numbers between 10 to 11 for mobile no."/>
					</label><br><br>
					<label>
						Email: <input type="email" name="email"  value="" placeholder="email" required>
					</label><br><br>
 					
 					<label>
						Adresse: <input type="text" name="adresse" value="" placeholder="adresse">
					</label><br><br>
					<label>
						Sexe: <select name="sexe" required>
										<option value="">-select-</option>
										<option value="Homme">Masculin</option>
										<option value="Femme">Féminin</option>
									</select>
					</label><br><br>
					
					
					<label>
						Mot de passe: <input type="password" name="mdp"  value="" placeholder="mot de passe" required>
					</label><br><br>
					
					
					<button name="submit" type="submit" style="margin-left:60px;width: 85px;border-radius: 3px;">Inscription</button> <br>
				
			</div>	<!-- col-md-12 -->


				</form>
			</div>




	</div>
	
	



	
	
 <?php include('footer.php'); ?>


	
	</div><!--  containerFluid Ends -->




	<script src="js/bootstrap.min.js"></script>


	 <!-- inscription patient -->


				<?php
						include('config.php');
						if(isset($_POST['submit'])){

						$sql1 = "SELECT * FROM patient WHERE email='".$_POST["email"]."' ";
             		    $result = $conn->query($sql1);	
             		    if ($result->num_rows > 0) {
			                  echo "<script>alert('Vous êtes déjà inscrit, !');</script>";
			             }
						else{
							$sql = "INSERT INTO patient (NIR,Nom_Pat,Prenom_Pat,Age_Pat,Telephone,email,Adresse,Sexe,Mdp)
							VALUES ('" . $_POST["NIR"] ."','" . $_POST["nom"] ."','" . $_POST["prenom"] ."','" . $_POST["age"] . "','" . $_POST["contact"] . "','" . $_POST["email"] . "','" . $_POST["adresse"] . "','" . $_POST["sexe"] . "','" . $_POST["mdp"] . "' )";
                             $sql = "INSERT INTO agenda (Age_Pat,Sexe,email)
							 VALUES ('" . $_POST["age"] . "','" . $_POST["sexe"] . "','" . $_POST["email"] . "')";
							if ($conn->query($sql) === TRUE) {
							    echo "<script>location.replace('patient_success_msg.php');</script>";
							} else {
							    echo "<script>alert('Erreur détectée')<script>" . $sql . "<br>" . $conn->error;
							}

							$conn->close();
						}
					}
				?> 



	



</body>
</html>