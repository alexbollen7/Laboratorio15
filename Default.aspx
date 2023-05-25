<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio15._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 align="center">SUBIR IMAGENES</h1>
        <p class="lead">Descripción:
            <asp:TextBox ID="TextBoxDecripcion" runat="server" Width="316px"></asp:TextBox>
        </p>
        <p class="lead">Cargar imagen:&nbsp;&nbsp;
            <asp:Label ID="LabelEstado" runat="server" Text="[ESTADO]"></asp:Label>
&nbsp;<asp:FileUpload ID="FileUploadImagenes" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p class="lead">
            <asp:Button ID="ButtonGrabar" runat="server" OnClick="ButtonGrabar_Click" Text="Grabar" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
