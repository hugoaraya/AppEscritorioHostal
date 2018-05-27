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

        public DataTable OPXNumero(string numero) 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("IDORDEN_PEDIDO,NRO_ORDEN,EMPLEADO_ID,FECHA,PROVEEDOR_ID,ESTADO_ORDEN_PEDIDO_ID from ORDEN_PEDIDO where NRO_ORDEN = :num", conexion.con);
                comando.Parameters.Add(":num", numero);
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

        public DataTable UnaOP(string num)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT H.RUT,H.DV,H.NOMBRE,H.APELLIDO,H.TELEFONO,H.CORREO,H.CARGO,E.RUT AS RUT_EMPRESA FROM HUESPED H JOIN EMPRESA E ON(H.EMPRESA_ID = E.IDEMPRESA) WHERE NRO_ORDEN = :num", conexion.con);
            //Obtener información de los txt
            comando.Parameters.Add("num", num);
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
                Console.WriteLine("intente nuevamente.");
                lector.Close();
                conexion.Cerrar();
                return null;
            }
        }

    }
}
