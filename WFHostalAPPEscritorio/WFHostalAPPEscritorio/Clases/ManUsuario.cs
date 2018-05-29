using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;

using DAO;
using System.Data;

namespace WFHostalAPPEscritorio.Clases
{
    public class ManUsuario
    {
        
        public List<string> traerUsuario(string nombreUsu) //ENVIAR TODOS LOS DATOS DEL USUARIO
        {
            List<String> lista = new List<String>();

            Conectar conexion = new Conectar();
            conexion.Abrir();

                OracleCommand comando = new OracleCommand("SELECT USUARIO.IDUSUARIO, USUARIO.NOMBRE_USUARIO, USUARIO.CONTRASENIA, USUARIO.TIPO_USUARIO_ID, TIPO_USUARIO.DESCRIPCION FROM USUARIO JOIN TIPO_USUARIO ON (USUARIO.TIPO_USUARIO_ID = TIPO_USUARIO.IDTIPO_USUARIO) WHERE USUARIO.NOMBRE_USUARIO= :usuario ", conexion.con);
                //Obtener información de los txt
                comando.Parameters.Add(":usuario", nombreUsu);

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

        public DataTable TodosUsuarios() //ENVIAR TODOS LOS USUARIOS
        {
            
            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT USUARIO.IDUSUARIO, USUARIO.NOMBRE_USUARIO, TIPO_USUARIO.DESCRIPCION FROM USUARIO JOIN TIPO_USUARIO ON (USUARIO.TIPO_USUARIO_ID = TIPO_USUARIO.IDTIPO_USUARIO)", conexion.con);
            //Obtener información de los txt

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
        public DataTable UnUsuario(string pNombre) //ENVIAR TODOS LOS USUARIOS
        {

            DataTable dt = new DataTable();
            Conectar conexion = new Conectar();
            conexion.Abrir();

            OracleCommand comando = new OracleCommand("SELECT IDUSUARIO, NOMBRE_USUARIO, CONTRASENIA FROM USUARIO WHERE NOMBRE_USUARIO = :pNOMBRE_USUARIO", conexion.con);
            //Obtener información de los txt
            comando.Parameters.Add("pNOMBRE_USUARIO", pNombre);
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

        


    
