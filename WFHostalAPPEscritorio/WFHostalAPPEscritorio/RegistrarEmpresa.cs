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
            if (string.IsNullOrEmpty(txRut.Text))
            {
                lbMsg.Text = ("Debe completar la informacion RUT");
                txRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Debe completar la informacion NOMBRE");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txDireccion.Text))
            {
                lbMsg.Text = ("Debe completar la informacion DIRECCION");
                txDireccion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txTelefono.Text))
            {
                lbMsg.Text = ("Debe completar la informacion TELEFONO");
                txTelefono.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txCorreo.Text))
            {
                lbMsg.Text = ("Debe completar la informacion CORREO");
                txCorreo.Focus();
                return;
            }
            
            int id_usu = 0;
            ManEmpresa man = new ManEmpresa();
            MetodosAPP APP = new MetodosAPP();
            if (man.validarRutEmpresa(txRut.Text))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = txRut.Text;
                usu.CONTRASENIA = "123";                     // generar contraseña
                usu.TIPO_USUARIO_ID = 4;                     // 4 Cliente Empresa
                AddUsuario(usu);
                id_usu = man.ObtenerIDUsuario(txRut.Text);
                if (id_usu == 0)
                {
                    lbMsg.Text = "Problemas con generacion de Usuario";
                }
                else {
                    EMPRESA emp = new EMPRESA();
                    emp.IDEMPRESA = 1;
                    emp.RUT = int.Parse(txRut.Text);
                    emp.DV = APP.GenerarDV(txRut.Text);
                    emp.NOMBRE = txNombre.Text;
                    emp.DIRECCION = txDireccion.Text;
                    emp.TELEFONO = int.Parse(txTelefono.Text);
                    emp.USUARIO_ID = id_usu;
                    emp.CORREO = txCorreo.Text;
                    AddEmpresa(emp);
                    btnCancelar.Text = "Salir";
                    lbMsg.Text = "Usuario Creado";
                    txResult.Visible = true;
                    txResult.Text = (" Usuario para el Sistema : " + txRut.Text +
                                  " Clave para el Sistema   : 123 ");

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
