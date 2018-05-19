using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Conectar conexion = new Conectar();
            conexion.Abrir();
            
            if (txtUsuario.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar Usuario";
                txtUsuario.Focus();
            }
            else if (txtContra.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar Contraseña";
                txtContra.Focus();
            }
            else
            {
                OracleCommand comando = new OracleCommand("SELECT NOMBRE_USUARIO, CONTRASENIA, TIPO_USUARIO_ID FROM USUARIO WHERE NOMBRE_USUARIO= :usuario AND CONTRASENIA= :contra ", conexion.con);
                    //Obtener información de los txt
                    comando.Parameters.Add(":usuario", txtUsuario.Text);
                    comando.Parameters.Add(":contra", txtContra.Text);               

                    OracleDataReader lector = comando.ExecuteReader();

                //
                MantenedorUsuario man = new MantenedorUsuario();
                if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                        //:::NO CREO SEA NECESARIO::: CREAR UNA CLASE USUARIO..
                            String nombre = lector.GetString(0);
                            String clave = lector.GetString(1);
                            int tipo = lector.GetInt32(2);

                        //nueva conexion para comprobar datos de usuario registrado
                        conexion.Cerrar();
                        List<string> usuarioKEY = man.traerUsuario(nombre);
                            Console.Write(usuarioKEY);
                            

                            if (tipo == 1)
                            {
                                this.Hide();
                                FormularioAdmin formulario = new FormularioAdmin();
                                formulario.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                this.Hide();
                                FormularioEmpleado formulario = new FormularioEmpleado();
                                formulario.ShowDialog();
                                this.Close();
                        }
                        
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                        lbMsg.Text = "Usuario/Contraseña Invalido, intente nuevamente.";
                    }

                    lector.Close();
                    
            
            }
            conexion.Cerrar();
        }

    }
}
