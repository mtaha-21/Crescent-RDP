<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RDP.WebForm1" %>


<!DOCTYPE html>
<html>
	<head runat="server">
		<title></title>
	<link rel="stylesheet" type="text/css" href="css/app_form.css">
	<script type="text/javascript" src="bootstrap/js/app_form.js"></script>
	</head>
	<body>
<div class="container">
	<div class="form-container">
		
		<div class="header">
			<h1>Application form</h1>
			<p>This application form will automaticly validate as you aproach the mouse to the apply now button.<br/> All with the power of JS</p>
		</div>
		
		<form action="#">
			
			<div class="form-group">
				<div class="input-group">
					<label for="fname">First Name <span>*</span></label>
					<input type="text" name="fname" value="Mario">
				</div>
				<div class="input-group">
					<label for="lname">Last Name <span>*</span></label>
					<input type="text" name="lname">
				</div>
			</div>
			
			<div class="form-group">
				<div class="input-group">
					<label for="address">Address <span>*</span></label>
					<input type="text" name="address">
				</div>
				<div class="input-group">
					<label for="postcode">Post-code <span>*</span></label>
					<input type="text" name="postcode" value="SE1 4KL">
				</div>
			</div>
			
			<div class="form-group">
				<div class="input-group">
					<label for="city">City <span>*</span></label>
					<input type="text" name="city" value="London">
				</div>
				<div class="input-group">
					<label for="country">Country <span>*</span></label>
					<input type="text" name="country" value="United Kingdom">
				</div>
			</div>
			
			<button class="submit" type="submit">Apply Now</button>
			
		</form>
	</div>
</div>
</body>
</html>
