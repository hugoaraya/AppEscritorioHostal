using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio.Clases
{
    public class MantenedorUsuario
    {
        public List<string> traerUsuario(string nombreUsu) //ENVIAR TODOS LOS DATOS DEL USUARIO
        {
            //string query = "SELECT * FROM usuario WHERE rut = ?usuario";
            string query = "SELECT USUARIO.IDUSUARIO, USUARIO.NOMBRE_USUARIO, USUARIO.CONTRASENIA, USUARIO.TIPO_USUARIO_ID, TIPO_USUARIO.DESCRIPCION FROM USUARIO JOIN TIPO_USUARIO ON (USUARIO.TIPO_USUARIO_ID = TIPO_USUARIO.IDTIPO_USUARIO) WHERE USUARIO.NOMBRE_USUARIO= :usuario;";
            Console.WriteLine("Hugo " + query);
            
                Conectar conexion = new Conectar();
                conexion.Abrir();

                List<string> lista = new List<string>();

                OracleCommand comando2 = new OracleCommand("SELECT USUARIO.IDUSUARIO, USUARIO.NOMBRE_USUARIO, USUARIO.CONTRASENIA, USUARIO.TIPO_USUARIO_ID, TIPO_USUARIO.DESCRIPCION FROM USUARIO JOIN TIPO_USUARIO ON (USUARIO.TIPO_USUARIO_ID = TIPO_USUARIO.IDTIPO_USUARIO) WHERE USUARIO.NOMBRE_USUARIO= :usuario ;", conexion.con);
                Console.WriteLine("Hugo "+ nombreUsu);
                comando2.Parameters.Add(":usuario", nombreUsu);


                 OracleDataReader lector = comando2.ExecuteReader();

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
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                lector.Close();

                conexion.Cerrar();
                return lista;

        }
    }
}