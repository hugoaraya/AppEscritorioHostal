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
                        conexion.Cerrar();
                        return lista;
                }
                    else
                    {
                        Console.WriteLine("No rows found.");
                        Console.WriteLine("Usuario/Contraseña Invalido, intente nuevamente.");
                        conexion.Cerrar();
                        return null;
                    }   
                }
        }
    }
