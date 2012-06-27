using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BiProxy
{
    public class COperaciones:CHerramientas
    {
        public override double Sumaventas(DataTable oTabla) {

            double Sumatotal = 0;
            for (int i = 0; i < oTabla.Rows.Count;i++ )
            {
                Sumatotal =+ double.Parse(oTabla.Rows[i]["Importe"].ToString());
            }

            return Sumatotal;
        }
    }
}
