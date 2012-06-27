using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Cliente:Usuario
    {
        private string codCliente;

        public string CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
                

        public Cliente()
            :base()
        {
            this.CodCliente= "";
        }
        public Cliente(string pdi, string puser, string ppass, string pnombre, string papepa, string papema, string ptipo, string pestado, string pcod)
             :base(pdi, puser, ppass, pnombre, papepa, papema, ptipo, pestado)
        {
            this.CodCliente = pcod;
        }
         public override Usuario Clonar()
         {
             return (Usuario)this.MemberwiseClone();
         }
    }
}
