<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estados_PuntoVenta.aspx.cs" Inherits="App_Supervisor.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
                <asp:DropDownList ID="drop_Pventa" runat="server"></asp:DropDownList>
                <asp:Button ID="boton_listar"  Text="Listar" OnClick="evento_boton_listar" runat="server"/>
                <asp:GridView  Visible="false" ID="Listar_Pventa" runat="server" AutoGenerateColumns="false" CellPadding="4"
                        ForeColor="#333333" GridLines="None"   >
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" Text=">>" />
             

                            <asp:BoundField DataField="Punto_Venta" HeaderText="PuntoVenta" SortExpression="Punto_Venta" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                            <asp:BoundField Visible="true" DataField="IDPuntoventa" HeaderText="IDPuntoventa" SortExpression="IDPuntoventa" />
                            <asp:BoundField Visible="true" DataField="IDRuta" HeaderText="IDRuta" SortExpression="IDRuta" />
                                                   
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                </asp:GridView>

                <asp:Button Visible="false" ID="boton_Azul" OnClick="evento_boton_azul" Text="Cambiar Estado Espera"  runat="server"/>
                <asp:Button Visible="false" ID="boton_Verde" OnClick="evento_boton_verde" Text="Cambiar Estado Compro" runat="server"/> 
                <asp:Button Visible="false" ID="boton_Rojo" OnClick="evento_boton_rojo" Text="Cambiar EstadoNo Compra"  runat="server"/>   
                
            </td>
        </tr>
    </table>  
</asp:Content>
