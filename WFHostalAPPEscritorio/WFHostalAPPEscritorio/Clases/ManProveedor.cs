using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManProveedor
    {

        public DataTable todosEmpleados() 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select RUT,DV,NOMBRE,DIRECCION,RUBRO,USUARIO_ID from PROVEEDOR", conexion.con);
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

        public DataTable ProveedorXRut(String rut) 
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select RUT,DV,NOMBRE,DIRECCION,RUBRO,USUARIO_ID from PROVEEDOR where RUT = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
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


        public int ObtenerIDUsuario(String rut)
        {
            int id_empresa = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDUSUARIO from USUARIO where NOMBRE_USUARIO = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    DataRow row = dt.Rows[0];
                    id_empresa = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_empresa;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return 0;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: " + ex);
                conexion.Cerrar();
                return 0;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                conexion.Cerrar();
                return 0;
            }
        }

        public Boolean validarRutProveedor(String rut)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select RUT,DV,NOMBRE,DIRECCION,RUBRO,USUARIO_ID from PROVEEDOR where RUT = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    conexion.Cerrar();
                    return false;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    lector.Close();
                    conexion.Cerrar();
                    return true;
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
    }
}
