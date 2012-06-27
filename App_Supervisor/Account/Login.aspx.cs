using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Procesos_Entidades;

namespace App_Supervisor.Account
{
    public partial class Login : System.Web.UI.Page
    {
        Procesos_Usuario us_pro = new Procesos_Usuario();
        Procesos_Supervisor su_pro = new Procesos_Supervisor();
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            
            //if ((Usuario)Session["Online_user"] != null)
            //{
            //    LlenarDatos((Usuario)Session["Online_user"]);
            //    if ((bool)Session["Detalles"])
            //        Detalles();
            //}
            //LoginUser.FailureText = (string)Session["LoginError"];
        }
        protected void login_user_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Supervisor us = new Supervisor();
            us.User = LoginUser.UserName;
            us.Pass = LoginUser.Password;
            if (us_pro.Autentificar(us))            
            {
                if (!us_pro.VeriOnline(us.User))
                {                
                    us = us_pro.Loguear_user(us.User);                    
                    //Page.Session.Add("Detalles", false);

                    if (us.Idtipousuario== "1")
                    {
                        us_pro.Cambiar_Estado(us);
                        us.Estado = "OnLine";
                        Page.Session.Add("Online_user", us);
                        //Page.Session.Add("UsuarioB", us.nombre);                        
                        //e.Authenticated = true;
                        //LoginUser.Page.Validate("LoginUserValidationGroup");
                        //LoginUser.Page.Session.Add("Usu", us);
                        
                        
                        //bool asd = LoginUser.Page.Request.IsAuthenticated;
                        //bool sdgfg = asd;
                        //e.Authenticated = true;
                        //LoginStatus asd = new LoginStatus();
                        //asd = Request.IsAuthenticated;
                        
                        
                          
                        //LoginUser.Page.Session.Add("on", us);
                        Response.Redirect("../Home_Supervisor.aspx");
                        
                    }
                    else
                    {
                        Page.Session.Add("LoginError","El Tipo de Usuario no esta Disponible");                    
                    }
                }
            else
                Page.Session.Add("LoginError","El usuario ya se encuentra conectado");
        }
        else
            Page.Session.Add("LoginError","Usuario o contraseña incorrecta, vuelva a intentarlo");
        }
        

        //public void LlenarDatos(Usuario user, Ent_Farmacia far, Ent_Empleado emp)
        //{
        //    login_user.Visible = false;
        //    panel_user.Visible = true;

        //    if (user.tipo_cuenta == "User")
        //    {
        //        bot_user.Text = user.user + " [Logout]";
        //        image.ImageUrl = @"Img\Usuarios\" + user.imagen;
        //    }
        //    else if (user.tipo_cuenta == "Farma")
        //    {
        //        PanelB_fama.Visible = true;
        //        bot_user.Text = user.user + " [Logout]";
        //        label_ff.Visible = true;
        //        label_ff.Text = "(" + far.nombre + ")";
        //        image.ImageUrl = @"Img\Usuarios\" + user.imagen;
        //    }
        //    else if (user.tipo_cuenta == "Emp")
        //    {
        //        if (pro_emp.VeriAutorizacion(emp))
        //        {
        //            bot_user.Text = user.user + " [Logout]";
        //            label_ff.Visible = true;
        //            label_ff.Text = "Empleado - (" + pro_emp.NomFarma(emp.id_farmacia) + ")";
        //            image.ImageUrl = @"Img\Usuarios\" + user.imagen;
        //        }
        //        else
        //        {
        //            Page.Session.Add("LoginError", "Usted a sido desconectado");
        //            Response.Redirect("Index.aspx");
        //            panel_user.Visible = false;
        //            login_user.Visible = true;
        //        }
        //    }
        //}
    }
}
