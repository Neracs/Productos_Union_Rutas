using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSQLserver;
using System.Data;
using Entidades;

namespace Procesos_Entidades
{
    public class Procesos_Supervisor //esto parece proxy
    {
        Querys query = new Querys();        
        public DataTable ObtenerDropRuta()
        {
            return query.Search_Data("select distinct r_nombre from TRuta");
        }
        //facade ------
        public DataTable ListarAgente()
        {
            return query.Search_Data("select a_nombre Nombre,a_apePat Apellido,a_dni Dni from TAgente");
        }
        public DataTable ListarCliente()
        {
            return query.Search_Data("select c_nombre Nombrec,c_apePat Apellidoc,c_dni Dnic from TCliente");
        }
        public DataTable ListarPuntoVenta()
        {
            return query.Search_Data("select r.r_nombre Ruta,pv.p_nombre Punto_Venta from TPuntoventa pv, TRuta r where pv.idruta=r.idruta");
        }        
        //----

        //Estado----

        public DataTable ListarEstadosPV(string Ruta)
        {
            return query.Search_Data("select r.idruta IDRuta, pv.idpuntoventa IDPuntoventa, pv.p_nombre Punto_Venta, pv.p_estado Estado  from TPuntoventa pv, TRuta r where pv.idruta=r.idruta AND r.r_nombre='" + Ruta + "'");
        }
        public DataTable CabiarEstadoAzul(int idruta, string estado)
        {
            return query.EjecutarProcedimientoAlmacenado("uspModificarEstadoAzul"," "+idruta + ",'" + estado + "'");
        }
        public DataTable CabiarEstadoRojo(int idpuntoventa, string estado)
        {
            return query.EjecutarProcedimientoAlmacenado("uspModificarEstadoRojo", " " + idpuntoventa + ",'" + estado + "'");
        }
        public DataTable CabiarEstadoVerde(int idpuntoventa, string estado)
        {
            return query.EjecutarProcedimientoAlmacenado("uspModificarEstadoVerde", " " + idpuntoventa + ",'" + estado + "'");
        }
        //----
        //Proxy----
        public DataTable Listarloginsupervisor()
        {
            return query.Search_Data("select su.su_login Login from TSupervisor su, TTipoUsuario ttu where ttu.idtipoUsuario = su.idtipoUsuario");
        }
        //----
        public DataTable ObtenerReporteAgente(string dniAgente)
        {
            return query.EjecutarProcedimientoAlmacenado("uspMostarVentaPorAgente"," '"+dniAgente+"'");
        }
        public DataTable ObtenerReporteGeneral(string datos)
        {
            return query.EjecutarProcedimientoAlmacenado("uspMostrarVentasGeneral",datos);
        }
        public DataTable ObtenerReporteCliente(string dniCliente)
        {
            return query.EjecutarProcedimientoAlmacenado("uspMostarVentaPorCliente", " '" + dniCliente + "'");
        }
        public DataTable ObtenerReporteFecha(string fecha)
        {
            return query.EjecutarProcedimientoAlmacenado("uspMostarVentaPorFecha", " '" + fecha + "'");
        }
        public DataTable ObtenerReporteRuta(string nombreruta)
        {
            return query.EjecutarProcedimientoAlmacenado("uspMostarVentaPorRuta", " '" + nombreruta + "'");
        }
    }
}
