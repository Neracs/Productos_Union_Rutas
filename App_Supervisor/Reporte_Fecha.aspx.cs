using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Procesos_Entidades;
using System.Data;
using Memento;
using BiProxy;

namespace App_Supervisor
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {
        Procesos_Supervisor pro_Supervisor = new Procesos_Supervisor();
        Supervisor usu_Master = new Supervisor();
        DataTable dt;
        FechaMemory fm = new FechaMemory();
        CFecha cf = new CFecha();
        CProxy oProxy = new CProxy();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Usuario)Session["Online_user"] != null)
            {
                NavigationMenu1.Visible = true;
            }
        }
        protected void evento_boton_buscar(object sender, EventArgs e)
        {
            //cf.Fecha = this.textbox_Fecha.Text;
            //fm.Memoria= cf.saveMemento();
            if (oProxy.Validarfecha(textbox_Fecha.Text))
            {
                dt = pro_Supervisor.ObtenerReporteFecha(textbox_Fecha.Text);
                Reporte_fecha.DataSource = dt;
                Reporte_fecha.DataBind();
                Reporte_fecha.Visible = true;
                boton_suma.Visible = true;
            }
            else
            {
                
                //"<script language=javascript>alert('hl');</script>
                Response.Write("<script language=javascript>alert('"+oProxy.mensajeError()+"'); </script>");
                
            }
        }
        protected void evento_boton_calcular(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteFecha(textbox_Fecha.Text);
            labelVenta.Text=oProxy.Sumaventas(dt).ToString();
            labelVenta.Visible = true;
            //labelVenta.Text = dt.Rows[0][0].ToString();
        }
        //protected void evento_boton_otra(object sender, EventArgs e)
        //{
        //    //cf.Fecha = this.textbox_Fecha.Text;
        //    //txt_fecha.Text = cf.Fecha;
        //    cf.Fecha = this.textbox_Fecha.Text;
        //    fm.Memoria = cf.saveMemento();
        //}
        //protected void evento_boton_restore(object sender, EventArgs e)
        //{
        //    cf.restoreMemento(fm.Memoria);
        //    this.textbox_Fecha.Text = cf.Fecha;
        //    //txt_fecha_rest.Text = f
        //}
        //<asp:Label Visible="false" ID="txt_fecha" runat="server"></asp:Label>
        //<asp:Label Visible="false" ID="txt_fecha_rest" runat="server"></asp:Label>     
        //<asp:Button Visible="false" ID="boton_restore"  Text="Restaurar" OnClick="evento_boton_restore" runat="server"/>
        //<asp:Button Visible="false" ID="boton_otrabus"  Text="otra" OnClick="evento_boton_otra" runat="server"/>
    }
}