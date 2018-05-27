using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFHostalAPPEscritorio.Clases;
using Oracle.DataAccess.Client;
using DAO;
using System.Data;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManEmpleado
    {
        public List<string> traerEmpleado(string rutEmple) //ENVIAR TODOS LOS DATOS DEL EMPLEADO
        {
            List<String> lista = new List<String>();

            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT EMPLEADO.IDEMPLEADO, EMPLEADO.RUT, EMPLEADO.DV, EMPLEADO.NOMBRE, EMPLEADO.APELLIDO, TIPO_USUARIO.DESCRIPCION FROM EMPLEADO JOIN TIPO_USUARIO ON (EMPLEADO.TIPO_USUARIO_ID = TIPO_USUARIO.IDTIPO_USUARIO) WHERE EMPLEADO.RUT= :empleado ", conexion.con);
            //Obtener información de los txt
            comando.Parameters.Add(":empleado", rutEmple);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    lista.Add(lector.GetInt32(0).ToString());
                    lista.Add(lector.GetString(1));
                    lista.Add(lector.GetString(2));
                    lista.Add(lector.GetInt32(3).ToString());
                    lista.Add(lector.GetString(4));

                }
                lector.Close();
                conexion.Cerrar();
                return lista;
            }
            else
            {
                Console.WriteLine("No rows found.");
                Console.WriteLine("Usuario/Contraseña Inválido, intente nuevamente.");
                lector.Close();
                conexion.Cerrar();
                return null;
            }
        }

        public Boolean validarRutEmpleado(String rut)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPLEADO,RUT,DV,NOMBRE,APELLIDO, USUARIO_ID from EMPLEADO where RUT = :rut", conexion.con);
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

        public int ObtenerIDUsuario(String rut)
        {
            int id_empleado = 0;
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
                    id_empleado = int.Parse(row[0].ToString());
                    lector.Close();
                    conexion.Cerrar();
                    return id_empleado;
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

        public DataTable EmpleadoXRut(String rut)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPLEADO,RUT,DV,NOMBRE,APELLIDO,USUARIO_ID from EMPLEADO where RUT = :rut", conexion.con);
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

        public DataTable todosEmpleados()
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select RUT,DV,NOMBRE,APELLIDO from EMPLEADO", conexion.con);
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
