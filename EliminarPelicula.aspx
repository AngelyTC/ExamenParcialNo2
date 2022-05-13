<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarPelicula.aspx.cs" Inherits="ExamenParcialNo2.EliminarPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        ELIMINAR PELICULAS</p>
    <p>
        Ingrese Año</p>
    <p>
        <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Pelicula" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Título"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Genero"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Estudio"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtEstudio" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Pelicula" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
