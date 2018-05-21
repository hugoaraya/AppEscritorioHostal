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
               
                if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                        //:::NO CREO SEA NECESARIO::: CREAR UNA CLASE USUARIO..
                        //Mmmmm...... ño
                            String nombre = lector.GetString(0);
                            String clave = lector.GetString(1);
                            int tipo = lector.GetInt32(2);

                            //registros de Usuario
                            MantenedorUsuario man = new MantenedorUsuario();
                            //List<string> listUsuario = man.traerUsuario(txtUsuario.Text);
                            //Console.Write(listUsuario[0] + listUsuario[1] + listUsuario[2] + listUsuario[3] + listUsuario[4]);
                            Global.usuarioKEY = man.traerUsuario(txtUsuario.Text);

                        if (tipo == 1)
                        {
                            this.Hide();
                            FormularioAdmin formulario = new FormularioAdmin();
                            formulario.ShowDialog();
                            this.Close();
                        }
                        else if (tipo == 4)
                        {
                            this.Hide();
                            FormularioEmpleado formulario = new FormularioEmpleado();
                            formulario.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            lbMsg.Text = "Usuario No habilitado, intente nuevamente.";
                        }
                        
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                        lbMsg.Text = "Usuario/Contraseña Inválido, intente nuevamente.";
                    }

                    lector.Close();
                    
            
            }
            conexion.Cerrar();
        }

        //private void PruebaConexion_Click(object sender, EventArgs e)
        //{
        
            //    //nueva conexion para comprobar datos de usuario registrado
            //    MantenedorUsuario man = new MantenedorUsuario();

                //    List<string> listUsuario = man.traerUsuario(txtUsuario.Text);
                //    Console.Write(listUsuario[0] + listUsuario[1] + listUsuario[2] + listUsuario[3] + listUsuario[4]);
        
                //foreach (var item in Global.usuarioKEY)
                //{
                //    MessageBox.Show(item);
                //}

        //}
    }
}
