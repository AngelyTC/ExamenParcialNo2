<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExamenParcialNo2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                Ingreso Peliculas</p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Año"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtAño" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Genero"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Estudio"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtEstudio" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label5" runat="server" Text="Actores"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtActores" runat="server"></asp:TextBox>
                <asp:Button ID="btnElenco" runat="server" OnClick="btnElenco_Click" Text="Ingreso Elenco" />
            </p>
            <p>
                <asp:Label ID="Label7" runat="server" Text="Elenco"></asp:Label>
            </p>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
            <p>
                <asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento"></asp:Label>
            </p>
        </div>
        <div class="col-md-4">
            <asp:Calendar ID="CalendarFecha" runat="server"></asp:Calendar>
        </div>
        <br />
        <asp:Button ID="btnIngresoP" runat="server" Height="37px" OnClick="btnIngresoP_Click" Text="Ingreso Pelicula" Width="180px" />
        <br />
        <br />
        <br />
        <br />
    </div>

</asp:Content>
