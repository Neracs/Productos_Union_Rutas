using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BiFachada
{
    public class CInformacionFacade
    {
        
        private CAgente oAgente = new CAgente();
        private CCliente oCliente = new CCliente();
        private CPuntoVenta oPunto = new CPuntoVenta();
        DataTable oTabla, oTabla2, oTabla3;

        public DataTable VerFachada1()
        {
            oTabla = oAgente.ListarAgente();
            oTabla2 = oCliente.ListarCliente();
            oTabla3 = oPunto.ListarPuntoVenta();

            oTabla.Merge(oCliente.ListarCliente());
            oTabla.Merge(oPunto.ListarPuntoVenta());

            return oTabla;
        }
        public void VerFachada2()
        {
            oCliente.ListarCliente();
        }
        public void VerFachada3()
        {
            oPunto.ListarPuntoVenta();
        }
    }
}
