<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroEstudiante.aspx.cs" Inherits="PrimerParcialWF_DannyB.Registro.RegistroEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
		<div class="form-group">
			<!--ID-->
			<asp:Label ID="Label1" runat="server" Text="ID: "></asp:Label>
			<asp:TextBox ID="IDTextBox" type="numbre" runat="server"></asp:TextBox>
			<!--Buscar-->
			<asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Buscar" OnClick="Button1_Click" />
			&nbsp;&nbsp;
			<br />
			<!--Fecha-->
			<asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
			<asp:TextBox ID="FechaTextBox" type="time" runat="server"></asp:TextBox>
			&nbsp;&nbsp;
			<br />
			<!--Nombre-->
			<asp:Label ID="Label3" runat="server" Text="Nombre: "></asp:Label>
			<asp:TextBox ID="NombreTextBox" runat="server"></asp:TextBox>
			&nbsp;&nbsp;
			<br />
			<!--Categoria-->
			<asp:Label ID="Label4" runat="server" Text="Categoria: "></asp:Label>
			<asp:TextBox ID="CategoariaTextBox" runat="server"></asp:TextBox>
			<!--Valor-->
			<asp:Label ID="Label5" runat="server" Text="Valor: "></asp:Label>
			<asp:TextBox ID="ValorTextBox" type="numbre" runat="server"></asp:TextBox>
			<!--Logrado-->
			<asp:Label ID="Label6" runat="server" Text="Logrado: "></asp:Label>
			<asp:TextBox ID="LogradoTextBox" type="numbre" runat="server"></asp:TextBox>
			<!--Add-->
			<asp:Button ID="AddButton" CssClass="btn btn-primary" runat="server" Text="Add" OnClick="AddButton_Click"  />
			<!--detalle-->
			<asp:GridView ID="DetalleGridView" runat="server"></asp:GridView>
			<!--Logrado-->
			<asp:Label ID="Label7" runat="server" Text="Total: "></asp:Label>
			<asp:TextBox ID="TotalTextBox" type="numbre" runat="server" Enabled="False"></asp:TextBox>
			<!--botones-->
			
			<br />
			<asp:Button ID="NuevoButton" CssClass="btn btn-primary" runat="server" Text="Nuevo" OnClick="NuevoButton_Click"  />
			&nbsp;&nbsp;
			<asp:Button ID="GuardarButton" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
			&nbsp;&nbsp;
			<asp:Button ID="EliminarButton" CssClass="btn btn-danger" runat="server" Text="Eliminar"  />
		</div>
	</div>
</asp:Content>
