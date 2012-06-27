using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Supervisor:Usuario
    {
        private string codSupervisor;

        public string CodSupervisor
        {
            get { return codSupervisor; }
            set { codSupervisor = value; }
        }

        public Supervisor()
            :base()
        {
            this.CodSupervisor = "";
        }
         public Supervisor(string pdi, string puser, string ppass, string pnombre, string papepa, string papema, string ptipo, string pestado,string pcod)
             :base(pdi, puser, ppass, pnombre, papepa, papema, ptipo, pestado)
        {
            this.CodSupervisor = pcod;
        }
         public override Usuario Clonar()
         {
             return (Usuario)this.MemberwiseClone();
         }
        
    }
}
