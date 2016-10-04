<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Reto1.GUI.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Recursos/css/style.css" rel="stylesheet" />
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'>
</head>
<body>
    <form id="form1" runat="server">
    	<div class="main"> 
		<h1>Badge Sign In Form</h1>
		<div class="login-form"> 
			<h2>SignIn Form</h2> 
			<div class="agileits-top">
				<form action="#" method="post">
					<div class="styled-input">
						<input type="text" name="User Name" required=""/>
						<label>User Name</label>
						<span></span>
					</div>
					<div class="styled-input">
						<input type="password" name="Password" required=""> 
						<label>Password</label>
						<span></span>
					</div> 
					<div class="wthree-text"> 
						<ul> 
							<li>
								<input type="checkbox" id="brand" value="">
								<label for="brand"><span></span> Remember me ?</label>  
							</li>
							<li> <a href="#">Forgot password?</a> </li>
						</ul>
						<div class="clear"> </div>
					</div>  
				</form>
			</div>
			<div class="agileits-bottom">
				<form action="#" method="post">
					<input type="submit" value="Sign In">
				</form>
			</div>	
		</div>	


	</div>	

    </form>
</body>
</html>
