using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string ape_pa;

        public string Ape_pa
        {
            get { return ape_pa; }
            set { ape_pa = value; }
        }
        private string ape_ma;

        public string Ape_ma
        {
            get { return ape_ma; }
            set { ape_ma = value; }
        }
        private string idtipousuario;

        public string Idtipousuario
        {
            get { return idtipousuario; }
            set { idtipousuario = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        
        public Usuario()
        {
            this.Id = "";
            this.User = "";
            this.Pass = "";
            this.Nombre = "";
            this.Ape_pa = "";
            this.Ape_ma = "";
            this.Idtipousuario = "";
            this.Estado = "OffLine";         
        }
        public Usuario(string pdi, string puser, string ppass, string pnombre, string papepa, string papema, string ptipo, string pestado)
        {
            this.Id = pdi;
            this.User = puser;
            this.Pass = ppass;
            this.Nombre = pnombre;
            this.Ape_pa = papepa;
            this.Ape_ma = papema;
            this.Idtipousuario = ptipo;
            this.Estado = pestado;
        }
        public abstract Usuario Clonar();
    }
}
