using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BiProxy
{
    public abstract class CHerramientas
    {
        //CValidaciones
        public abstract bool Validardni(string dni);
        public abstract bool Validarfecha(string fecha);
        public abstract bool Validarporlogin(string login);
        //COperaciones
        public abstract double Sumaventas(DataTable oTabla);
        public abstract string mensajeError();
    }
}
