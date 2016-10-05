<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Reto1.GUI.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Badge Sign In Form template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs  Sign up Web Templates, Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Custom Theme files -->
    <link href="../Recursos/css/css_bootstrap.css" rel="stylesheet" />
    <link href="../Recursos/css/style.css" rel="stylesheet" />
    
<!-- //Custom Theme files -->
<!-- web font -->
<link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,600,700,800' rel='stylesheet' type='text/css'/><!--web font-->
             
  
   
</head>

   
<body>
    <form id="home" runat="server">
         <script src="../Recursos/js/jquery-3.1.1.min.js" type="text/javascript"></script>
         <h1>Web Form que lee un Archivo JSON</h1> 
  <br/>
  <select id="usuarios">
      <option value="0">[--Seleccione un Nombre--]</option>
   </select> 
   <span id="txtvalor" style="color: #008000; font-weight: bolder"></span>


   <div class="main"> 
                <!--Titulo-->
<h1>Búsqueda</h1>
      <div class="row">
          <!--DropDownlist Estados-->
		<div class="login-form col-sm-3 margen"> 

			<h2>Estado</h2>
			<div class="agileits-top">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label1" runat="server" Text="Seleccione un Estado..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlEstados" runat="server" CssClass="color" width="300px">
                            <asp:ListItem>
                                holi
                            </asp:ListItem>
                        </asp:DropDownList>
				</center>
                </div>
			</div>
			<div class="agileits-bottom">
                <asp:Button ID="btnSeleccionarEstado" runat="server" Text="Seleccionar" />
			</div>	
            </div>

 
           <!--DropDownlist Municipio-->
        <div class="login-form col-sm-3 margen"> 
			<h2>Municipio</h2>
			<div class="agileits-top">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label2" runat="server" Text="Seleccione un Municipio..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlMunicipio" runat="server" CssClass="color" width="300px">
                            <asp:ListItem>
                                holi
                            </asp:ListItem>
                        </asp:DropDownList>
				</center>
                </div>
			</div>
			<div class="agileits-bottom">
                <asp:Button ID="lbtnSeleccionarMunicipio" runat="server" Text="Seleccionar" />
			</div>	
            </div>

 
           <!--DropDownlist Localidad-->
        <div class="login-form col-sm-3 margen"> 
 

			<h2>Localidad</h2>
			<div class="agileits-top">
                <div class="styled-input">
					<center>
					<asp:Label ID="Label3" runat="server" Text="Seleccione una Localidad..." CssClass="color"></asp:Label>
                        <asp:DropDownList ID="ddlLocalidad" runat="server" CssClass="color" width="300px">
                            <asp:ListItem>
                                holi
                            </asp:ListItem>
                        </asp:DropDownList>
				</center>
                </div>
			</div>
			<div class="agileits-bottom">
                <asp:Button ID="lbtnSeleccionarLocalidad" runat="server" Text="Seleccionar" />
			</div>	
            </div>
         </div>
	</div>	
        <script type="text/javascript" >
            $(document).ready(function () {
                $.getJSON("datos.json", function (data) {
                    for (u in data.users.user) {
                        $("#usuarios").append("<option value=" + data.users.user[u].Id +
                                     ">" + data.users.user[u].nombre + "</option>");
                    }
                })

                $("#usuarios").change(function () {
                    var str = "";
                    $("#usuarios option:selected").each(function () {
                        str = $(this).val();
                    })
                    $("#txtvalor").text("Ha seleccionado el valor " + str);
                })
            });
        </script> 
    </form>
      
</body>
</html>
