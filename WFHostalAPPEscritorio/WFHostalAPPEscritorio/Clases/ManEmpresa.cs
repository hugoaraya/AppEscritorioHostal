using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManEmpresa
    {

        public DataTable todasEmpresas() //ENVIAR TODOS LOS DATOS DEL USUARIO
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try
            {
                OracleCommand comando = new OracleCommand("select IDEMPRESA,RUT||'-'||DV as RUT,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO from empresa", conexion.con);
                OracleDataReader lector = comando.ExecuteReader();
            
                if (lector.HasRows)
                {
                    dt.Load(lector);
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
                Console.WriteLine("ERROR SQL: "+ ex);
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                return null;
            }
        }
        public DataTable EmpresaXRut(String rut) //ENVIAR TODOS LOS DATOS DEL USUARIO
        {
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();
            try { 
                OracleCommand comando = new OracleCommand("select IDEMPRESA,RUT||'-'||DV as RUT,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO from empresa where RUT = :rut", conexion.con);
                comando.Parameters.Add(":rut", rut);
                OracleDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    dt.Load(lector);
                    lector.Close();
                    return dt;
                }
                else
                {
                    Console.WriteLine("No rows found.");
                    return null;
                }
                
            }
            catch (OracleException ex)
            {
                Console.WriteLine("ERROR SQL: "+ ex);
                return null;
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR APP: " + ex);
                return null;
            }
            
        }

        //public void InsertarEmpresa()

    }

}
