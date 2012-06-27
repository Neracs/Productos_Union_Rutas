using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Procesos_Entidades;
using System.Data;
using BiProxy;


namespace App_Supervisor
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        Procesos_Supervisor pro_Supervisor = new Procesos_Supervisor();
        Supervisor usu_Master = new Supervisor();
        DataTable dt;
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
            if(oProxy.Validardni(textbox_Cliente.Text))
            {
                dt = pro_Supervisor.ObtenerReporteCliente(textbox_Cliente.Text);
                Reporte_cliente.DataSource = dt;
                Reporte_cliente.DataBind();
                Reporte_cliente.Visible = true;
                boton_suma.Visible = true;
             }
            else
            {
                Response.Write("<script language=javascript>alert('" + oProxy.mensajeError() + "'); </script>");
            }
                
        }
        protected void evento_boton_calcular(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteCliente(textbox_Cliente.Text);
            labelVenta.Text = oProxy.Sumaventas(dt).ToString();
            labelVenta.Visible = true;
            //labelVenta.Text = dt.Rows[0][0].ToString();
        }
    }
}