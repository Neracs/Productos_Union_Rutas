<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home_Supervisor.aspx.cs" Inherits="App_Supervisor.Formulario_web11" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">            
    <asp:Menu Visible="false" ID="NavigationMenu1" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
        <Items>
            <asp:MenuItem NavigateUrl="~/MapGoogle.aspx" Text="Mapas"/>
            <asp:MenuItem NavigateUrl="~/Estados_PuntoVenta.aspx" Text="Estado Punto de Venta"/>
            <asp:MenuItem NavigateUrl="~/InformacionGeneral.aspx" Text="Informacion General"/>
            <asp:MenuItem NavigateUrl="~/Reporte_Venta.aspx" Text="Reportes">
            <asp:MenuItem NavigateUrl="~/Reporte_Agente.aspx" Text="Reportes por Agente"/>
            <asp:MenuItem NavigateUrl="~/Reporte_Cliente.aspx" Text="Reportes por Cliente"/>
            <asp:MenuItem NavigateUrl="~/Reporte_Fecha.aspx" Text="Reportes por Fecha"/>
            <asp:MenuItem NavigateUrl="~/Reporte_Ruta.aspx" Text="Reportes por Ruta"/>
            </asp:MenuItem>
        </Items>
    </asp:Menu>           
</asp:Content>
