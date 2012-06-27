<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InformacionGeneral.aspx.cs" Inherits="App_Supervisor.WebForm1" %>
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
    <table>
        <tr>
            <td>                                         
                <asp:GridView  Visible="false" ID="Reporte_facha" runat="server" AutoGenerateColumns="False" CellPadding="4"
                            ForeColor="#333333" GridLines="None">
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Select" Text=">>" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre_Agente" SortExpression="Nombre" />
                                <asp:BoundField DataField="Apellido" HeaderText="Apellido_Agente" SortExpression="Apellido" />
                                <asp:BoundField DataField="Dni" HeaderText="Dni_Agente" SortExpression="Dni" />
                                <asp:BoundField DataField="Nombrec" HeaderText="Nombre_Cliente" SortExpression="Nombre" />
                                <asp:BoundField DataField="Apellidoc" HeaderText="Apellido_Cliente" SortExpression="Apellido" />
                                <asp:BoundField DataField="Dnic" HeaderText="Dni_Cliente" SortExpression="Dni" />
                                <asp:BoundField DataField="Ruta" HeaderText="Nombre_Ruta" SortExpression="Ruta" />
                                <asp:BoundField DataField="Punto_Venta" HeaderText="Nombre_Punto_venta" SortExpression="P_Venta" />
                                
                                                                               
                            </Columns>                        
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <EditRowStyle BackColor="#999999" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>    
                
            </td>
        </tr>
    </table>       
</div>
</asp:Content>
