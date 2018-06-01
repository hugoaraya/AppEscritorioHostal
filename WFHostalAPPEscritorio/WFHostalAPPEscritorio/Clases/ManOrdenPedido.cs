using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManOrdenPedido
    {
        public DataTable todasOPedido() 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDORDEN_PEDIDO,NRO_ORDEN,EMPLEADO_ID,FECHA,PROVEEDOR_ID,ESTADO_ORDEN_PEDIDO_ID from ORDEN_PEDIDO", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }
        }

        public DataTable OPXNumero(String numero) 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT OP.NRO_ORDEN, OP.FECHA, E.NOMBRE as NOMBRE_EMPLEADO,E.RUT as RUT_EMPLEADO,P.NOMBRE as NOMBRE_PROVEEDOR, P.RUT as RUT_PROVEEDOR,EO.DESCRIPCION AS ESTADO_ODP FROM ORDEN_PEDIDO OP JOIN EMPLEADO E ON (OP.EMPLEADO_ID = E.IDEMPLEADO) join PROVEEDOR P ON(OP.PROVEEDOR_ID=P.IDPROVEEDOR) JOIN ESTADO_ORDEN_PEDIDO EO ON (EO.IDESTADO_ORDEN_PEDIDO=OP.ESTADO_ORDEN_PEDIDO_ID) WHERE OP.NRO_ORDEN= :numodp order by fecha", conexion.con);
                comando.Parameters.Add(":numodp", numero);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    lector.Close();
                    conexion.Cerrar();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    conexion.Cerrar();
                    return null;
                }

            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return null;
            }

        }


    }
}
