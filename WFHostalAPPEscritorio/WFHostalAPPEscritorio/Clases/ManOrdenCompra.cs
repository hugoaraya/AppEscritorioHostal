using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManOrdenCompra
    {
        public Boolean validarNroOrden(int pNroOrden)
        {
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT * FROM ORDEN_COMPRA WHERE NRO_ORDEN = :nroOrden", conexion.con);
                comando.Parameters.Add(":nroOrden", pNroOrden);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    conexion.Cerrar();
                    return true;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return false;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return false;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return false;
            }

        }


        public DataTable GetOrdenesxNro(int nroOrden)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT E.ESTADO AS ESTADO, U.RUT, U.DV, U.NOMBRE,U.APELLIDO,M.NOMBRE AS EMPRESA, O.NRO_ORDEN "+
                                                           "FROM ORDEN_COMPRA O JOIN HUESPED_HABITACION H ON(O.HUESPED_HABITACION_ID = H.IDHUESPED_HABITACION) "+
                                                           "JOIN HUESPED U ON(H.HUESPED_ID = U.IDHUESPED) JOIN ESTADO_HUESPED E ON(U.ESTADO_HUESPED_ID = E.IDESTADO_HUESPED) "+
                                                           "JOIN EMPRESA M ON(U.EMPRESA_ID = M.IDEMPRESA) "+
                                                           "WHERE NRO_ORDEN = :pNroOrden", conexion.con);
                comando.Parameters.Add(":pNroOrden", nroOrden);
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
    }
}
