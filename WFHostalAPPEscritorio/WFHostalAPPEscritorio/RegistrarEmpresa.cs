using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using WFHostalAPPEscritorio.Clases;


namespace WFHostalAPPEscritorio
{
    public partial class RegistrarEmpresa : Form
    {
        public RegistrarEmpresa()
        {
            InitializeComponent();
            //..EMPRESA
            //IDEMPRESA
            //RUT
            //DV
            //NOMBRE
            //DIRECCION
            //TELEFONO
            //USUARIO_ID
            //CORREO

            //..USUARIO
            //IDUSUARIO
            //NOMBRE_USUARIO
            //CONTRASENIA
            //TIPO_USUARIO_ID
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRut.Text)==false || txRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Válido");
                txRut.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txNombre.Text) || txNombre.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese la información NOMBRE +4");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txDireccion.Text))
            {
                lbMsg.Text = ("Ingrese la información DIRECCIÓN");
                txDireccion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txTelefono.Text))
            {
                lbMsg.Text = ("Ingrese la información TELÉFONO");
                txTelefono.Focus();
                return;
            }
            if (APP.ValidacionEmail(txCorreo.Text)==false)
            {
                lbMsg.Text = ("Ingrese la información CORREO válido");
                txCorreo.Focus();
                return;
            }
            
            int id_usu = 0;
            ManEmpresa man = new ManEmpresa();
            
            if (man.validarRutEmpresa(APP.ObtenerRut(txRut.Text)))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = APP.ObtenerRut(txRut.Text);
                usu.CONTRASENIA = APP.GenerarClave(txNombre.Text, txRut.Text); 
                usu.TIPO_USUARIO_ID = 2;       // 2 Cliente Empresa
                AddUsuario(usu);
                id_usu = man.ObtenerIDUsuario(APP.ObtenerRut(txRut.Text));
                if (id_usu == 0)
                {
                    lbMsg.Text = "Problemas con generación de Usuario";
                    return;
                }
                else {
                    EMPRESA emp = new EMPRESA();
                    emp.IDEMPRESA = 1;
                    emp.RUT = int.Parse(APP.ObtenerRut(txRut.Text));
                    emp.DV = APP.GenerarDV(APP.ObtenerRut(txRut.Text));
                    emp.NOMBRE = txNombre.Text;
                    emp.DIRECCION = txDireccion.Text;
                    emp.TELEFONO = int.Parse(txTelefono.Text);
                    emp.USUARIO_ID = id_usu;
                    emp.CORREO = txCorreo.Text;
                    AddEmpresa(emp);
                    btnCancelar.Text = "Salir";
                    lbMsg.Text = "Usuario Creado";
                    txResult.Visible = true;

                    txResult.Text += "Estimados " + txNombre.Text + "\r\n \r\n";
                    txResult.Text += "Estos son sus datos para poder acceder a nuestro Sistema.\r\n \r\n";
                    txResult.Text += ("     Usuario: " + APP.ObtenerRut(txRut.Text) + "\r\n"+
                                      "     Clave: " + APP.GenerarClave(txNombre.Text, txRut.Text))+"\r\n \r\n";

                    txResult.Text += "Lo invitamos a disfrutar de nuestros Servicios.\r\n";
                    txResult.Text += "Ingrese a www.HostalDonaClarita.cl \r\n \r\n \r\n";

                    txResult.Text += "Saludos. Hostal Doña Clarita\r\n \r\n \r\n";

                    txResult.Text += "**Enviar datos a "+ txCorreo.Text;
                    
                }
                
            }
            else
            {
                lbMsg.Text = "Rut Cliente ya Existe";
                txRut.Focus();
                return;
            }

        }
        
        public void AddEmpresa(EMPRESA emp)
        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.EMPRESA.Add(emp);
                con.SaveChanges();
            }
            btnIngresar.Visible = false;
        }
        public void AddUsuario(USUARIO usu)

        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.USUARIO.Add(usu);
                con.SaveChanges();
            }
        }
        //Validar que campos  sean numericos
        private void tx_KeyPress_Numeric(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
