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
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        Procesos_Supervisor pro_Supervisor = new Procesos_Supervisor();
        Supervisor usu_Master = new Supervisor();
        DataTable dt;
        DataTable dropdt;
        CProxy oProxy = new CProxy();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Usuario)Session["Online_user"] != null)
            {
                NavigationMenu1.Visible = true;
                dropdt = pro_Supervisor.ObtenerDropRuta();
                if (drop_ruta.Items.Count == 0)
                {
                    for (int i = 0; i < dropdt.Rows.Count; i++)
                    {
                        drop_ruta.Items.Add(dropdt.Rows[i][0].ToString());
                    }
                }
            }
        }
        protected void evento_boton_buscar(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteRuta(drop_ruta.SelectedValue.ToString());
            Reporte_Ruta.DataSource = dt;
            Reporte_Ruta.DataBind();
            Reporte_Ruta.Visible = true;
            boton_suma.Visible = true;
            
        }

        protected void evento_boton_calcular(object sender, EventArgs e)
        {
            dt = pro_Supervisor.ObtenerReporteRuta(drop_ruta.SelectedValue.ToString());
            labelVenta.Text=oProxy.Sumaventas(dt).ToString();
            labelVenta.Visible = true;
            //labelVenta.Text = dt.Rows[0][0].ToString();
        }
    }
}