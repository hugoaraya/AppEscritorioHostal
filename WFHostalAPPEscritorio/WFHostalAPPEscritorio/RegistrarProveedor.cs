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
    public partial class RegistrarProveedor : Form
    {

        #region Métodos
        public void AddProveedor(PROVEEDOR prov)
        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.PROVEEDOR.Add(prov);
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
        #endregion
        public RegistrarProveedor()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txtRut.Text) == false || txtRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Valido");
                txtRut.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese la información NOMBRE +4");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lbMsg.Text = ("Ingrese la información DIRECCIÓN");
                txtDireccion.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRubro.Text))
            {
                lbMsg.Text = ("Ingrese la información RUBRO");
                txtRubro.Focus();
                return;
            }

            int id_usu = 0;
            ManProveedor man = new ManProveedor();

            if (man.validarRutProveedor(APP.ObtenerRut(txtRut.Text)))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = APP.ObtenerRut(txtRut.Text);
                usu.CONTRASENIA = APP.GenerarClave(txtNombre.Text, txtRut.Text);
                usu.TIPO_USUARIO_ID = 3;       // 3 Proveedor
                AddUsuario(usu);
                id_usu = man.ObtenerIDUsuario(APP.ObtenerRut(txtRut.Text));
                if (id_usu == 0)
                {
                    lbMsg.Text = "Problemas con generación de Usuario";
                    return;
                }
                else
                {
                    PROVEEDOR prov = new PROVEEDOR();
                    prov.IDPROVEEDOR = 1;
                    prov.RUT = int.Parse(APP.ObtenerRut(txtRut.Text));
                    prov.DV = APP.GenerarDV(APP.ObtenerRut(txtRut.Text));
                    prov.NOMBRE = txtNombre.Text;
                    prov.DIRECCION = txtDireccion.Text;
                    prov.RUBRO = txtRubro.Text;
                    prov.USUARIO_ID = id_usu;
                    AddProveedor(prov);
                    btnCancel.Text = "Salir";
                    lbMsg.Text = "Usuario Creado";
                    txResult.Visible = true;

                    txResult.Text += "Estimado " + txtNombre.Text + "\r\n \r\n";
                    txResult.Text += "Estos son sus datos para poder acceder a nuestro Sistema.\r\n \r\n";
                    txResult.Text += ("     Usuario: " + APP.ObtenerRut(txtRut.Text) + "\r\n" +
                                      "     Clave: " + APP.GenerarClave(txtNombre.Text, txtRut.Text)) + "\r\n \r\n";
                   
                    txResult.Text += "Ingrese a www.HostalDonaClarita.cl para revisar Órdenes de Pedidos.\r\n \r\n \r\n";
                    txResult.Text += "Hostal Doña Clarita\r\n \r\n \r\n";

                    txResult.Text += "**Informar datos al Proveedor";

                }

            }
            else
            {
                lbMsg.Text = "Rut Proveedor ya Existe";
                txtRut.Focus();
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
