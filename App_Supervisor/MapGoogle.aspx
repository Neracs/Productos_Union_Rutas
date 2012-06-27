<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MapGoogle.aspx.cs" Inherits="App_Supervisor.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div > 
    <asp:Menu ID="NavigationMenu1" Visible="false" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
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
          

<iframe width="425" height="350" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.pe/maps/ms?msa=0&amp;msid=207991592567653252390.0004c0a61dba3a6975f88&amp;hl=es&amp;ie=UTF8&amp;t=m&amp;ll=-11.968633,-76.766882&amp;spn=0.060714,0.141477&amp;output=embed"></iframe><br /><small>Ver <a href="https://maps.google.com.pe/maps/ms?msa=0&amp;msid=207991592567653252390.0004c0a61dba3a6975f88&amp;hl=es&amp;ie=UTF8&amp;t=m&amp;ll=-11.968633,-76.766882&amp;spn=0.060714,0.141477&amp;source=embed" style="color:#0000FF;text-align:left">Indicaciones de ruta en coche para Chosica, Lurigancho, Provincia de Lima</a> en un mapa más grande</small>
</div>
</asp:Content>
