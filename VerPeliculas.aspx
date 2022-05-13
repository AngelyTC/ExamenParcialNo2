<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPeliculas.aspx.cs" Inherits="ExamenParcialNo2.VerPeliculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        VER PELICULAS</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Año"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscarP" runat="server" OnClick="btnBuscarP_Click" Text="Buscar Peliculas" />
    </p>
    <p>
        <asp:TextBox ID="txtVer" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
