using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManHuesped
    {
        public DataTable TodosHuepedes()
        {

            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("SELECT H.RUT, H.DV, H.NOMBRE, H.APELLIDO, H.TELEFONO, H.CORREO, H.CARGO, E.RUT AS RUT_EMPRESA, E.DV AS DV_EMPRESA FROM HUESPED H JOIN EMPRESA E ON(H.EMPRESA_ID = E.IDEMPRESA)", conexion.con);
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
        public DataTable UnHueped(string pRutH)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT H.RUT,H.DV,H.NOMBRE,H.APELLIDO,H.TELEFONO,H.CORREO,H.CARGO,E.RUT AS RUT_EMPRESA, E.DV AS DV_EMPRESA FROM HUESPED H JOIN EMPRESA E ON(H.EMPRESA_ID = E.IDEMPRESA) WHERE H.RUT = :pRut", conexion.con);
            //Obtener información de los txt
            comando.Parameters.Add(":pRut", pRutH);
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


        public Boolean validarRutHuesped(String rut)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select * from HUESPED where RUT = :rut", conexion.con);
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
        public int ObtenerIDEmpresa(String rut)
        {
            int id_empresa = 0;
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPRESA from EMPRESA where RUT =:idEMP", conexion.con);
                comando.Parameters.Add(":idEMP", rut);
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


        //SELECT H.RUT, H.DV, H.NOMBRE, H.APELLIDO, H.TELEFONO, H.CORREO, H.CARGO, E.RUT AS RUT_EMPRESA, E.DV AS DV_EMPRESA FROM HUESPED H JOIN EMPRESA E ON(H.EMPRESA_ID = E.IDEMPRESA) WHERE E.RUT = :pRut_Empresa

        public DataTable GetHuespedesXRut(string pRutE)
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT H.RUT, H.DV, H.NOMBRE, H.APELLIDO, H.TELEFONO, H.CORREO, H.CARGO, E.RUT AS RUT_EMPRESA, E.DV AS DV_EMPRESA FROM HUESPED H JOIN EMPRESA E ON(H.EMPRESA_ID = E.IDEMPRESA) WHERE E.RUT = :pRut_Empresa", conexion.con);
            //Obtener información de los txt
            comando.Parameters.Add(":pRut_Empresa", pRutE);
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
