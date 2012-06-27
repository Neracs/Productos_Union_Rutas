using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BiProxy
{
    public class CProxy:CHerramientas
    {
        private CValidaciones oValida = new CValidaciones();

        public override bool Validardni(string dni)
        {
            return oValida.Validardni(dni);
        }
        public override double Sumaventas(DataTable oTabla)
        {
            return oValida.Sumaventas(oTabla);
        }
        public override bool Validarfecha(string fecha)
        {
            return oValida.Validarfecha(fecha);
        }
        public override bool Validarporlogin(string login)
        {
            return oValida.Validarporlogin(login);
        }
        public override string mensajeError()
        {
            return oValida.mensajeError();
        }
    }
}
