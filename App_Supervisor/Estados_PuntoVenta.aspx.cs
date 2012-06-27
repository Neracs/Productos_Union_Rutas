using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using BiState;
using Procesos_Entidades;
using System.Data;

namespace App_Supervisor
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        Procesos_Supervisor pro_Supervisor = new Procesos_Supervisor();
        Supervisor usu_Master = new Supervisor();
        DataTable oTablaruta;
        DataTable oTablaLista;
        CCuenta miCuenta = new CCuenta();        

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Usuario)Session["Online_user"] != null)
            {
                NavigationMenu1.Visible = true;
                oTablaruta = pro_Supervisor.ObtenerDropRuta();
                if (drop_Pventa.Items.Count == 0)
                {
                    for (int i = 0; i < oTablaruta.Rows.Count; i++)
                    {
                        drop_Pventa.Items.Add(oTablaruta.Rows[i][0].ToString());
                    }
                }
            }
        }
        protected void evento_boton_listar(object sender, EventArgs e)
        {
            oTablaLista = pro_Supervisor.ListarEstadosPV(drop_Pventa.SelectedValue.ToString());
            Listar_Pventa.DataSource = oTablaLista;
            Listar_Pventa.DataBind();
            Listar_Pventa.Visible=true;
            boton_Azul.Visible = true;
            boton_Rojo.Visible = true;
            boton_Verde.Visible = true;
        }
        //protected void select_fila(object sender, EventArgs e)
        //{

        //    idventa = int.Parse(oTablaLista.Rows[Listar_Pventa.SelectedIndex]["IDPuntoVenta"].ToString());    
        //}
        protected void evento_boton_azul(object sender, EventArgs e)
        {
            
            oTablaLista = pro_Supervisor.ListarEstadosPV(drop_Pventa.SelectedValue.ToString());
            //string f1 = oTablaLista.Rows[0]["IDRuta"].ToString();
            //string f2 = oTablaLista.Rows[1]["IDRuta"].ToString();
            //string f3 = oTablaLista.Rows[2]["IDRuta"].ToString();
            //string asddfa = oTablaLista.Rows[Listar_Pventa.SelectedIndex]["IDPuntoventa"].ToString();
            //string dsdfsg = datosss;
            //string fff = oTablaLista.Rows[Listar_Pventa.SelectedIndex]["IDRuta"].ToString();
            //string asd = f1+f2+f3;
            miCuenta.Cambiarestado();
            int idruta = int.Parse(oTablaLista.Rows[1]["IDRuta"].ToString());
            int asd = idruta;
            pro_Supervisor.CabiarEstadoAzul(idruta,"Azul");
        }
        protected void evento_boton_rojo(object sender, EventArgs e)
        {
            oTablaLista = pro_Supervisor.ListarEstadosPV(drop_Pventa.SelectedValue.ToString());
            miCuenta.Cambiarestado();
            pro_Supervisor.CabiarEstadoRojo(int.Parse(oTablaLista.Rows[Listar_Pventa.SelectedIndex]["IDPuntoVenta"].ToString()),"Rojo");
        }
        protected void evento_boton_verde(object sender, EventArgs e)
        {
            oTablaLista = pro_Supervisor.ListarEstadosPV(drop_Pventa.SelectedValue.ToString());
            miCuenta.Cambiarestado();
            pro_Supervisor.CabiarEstadoVerde(int.Parse(oTablaLista.Rows[Listar_Pventa.SelectedIndex]["IDPuntoVenta"].ToString()), "Verde");
        }
    }
}