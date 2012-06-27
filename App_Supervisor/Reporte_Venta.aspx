<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte_Venta.aspx.cs" Inherits="App_Supervisor.Formulario_web1" %>
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
                <asp:GridView  Visible="false" ID="Reporte_super" runat="server" AutoGenerateColumns="false" CellPadding="4"
                        ForeColor="#333333" GridLines="None">
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" Text=">>" />
                            <asp:BoundField DataField="Ruta" HeaderText="Ruta" SortExpression="Ruta" />
                            <asp:BoundField DataField="PuntoVenta" HeaderText="PuntoVenta" SortExpression="PuntoVenta" />
                            <asp:BoundField DataField="Cliente" HeaderText="Cliente" SortExpression="Cliente" />
                            <asp:BoundField DataField="AgenteVentas" HeaderText="Agente" SortExpression="AgenteVentas" />
                            <asp:BoundField DataField="Importe" HeaderText="Importe" SortExpression="Importe" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>                           
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                <br />                
                <asp:Button ID="boton_suma" Visible="false" Text="Calcular" OnClick="evento_boton_calcular" runat="server"/> Total Venta: <asp:Label ID="labelVenta" Visible="false" runat="server"/>      
            </td>
        </tr>
    </table>    
</div>
</asp:Content>
