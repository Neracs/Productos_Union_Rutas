using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace App_Supervisor.Account
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {            
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);
            
            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";                
            }
            Response.Redirect(continueUrl);
        }
        //protected void boton_crear(object sender, EventArgs e) 
        //{
        //    Usuario usu = new Usuario();
        //    string anasd = RegisterUser.UserName.Contains(usu.user).ToString();
        //    string sdg = anasd;
        //}
        //protected void evento_boton_mostrar(object sender, EventArgs e)
        //{
        //Usuario usu = new Usuario();
        //string anasd = RegisterUser.UserName.Contains(usu.user).ToString();
        //string sdg = anasd;
        //}
        //<asp:Button ID="boton_mostrar"  Text="Buscar" OnClick="evento_boton_mostrar" runat="server"/>
        

    }
}
