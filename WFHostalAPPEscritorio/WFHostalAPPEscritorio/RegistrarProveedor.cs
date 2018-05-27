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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(txtRut.Text))
            {
                lbMsg.Text = ("Ingrese la información RUT");
                txtRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDv.Text))
            {
                lbMsg.Text = ("Ingrese la información DV");
                txtDv.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lbMsg.Text = ("Ingrese la información NOMBRE");
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
            MetodosAPP APP = new MetodosAPP();
            if (man.validarRutProveedor(txtRut.Text))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = txtRut.Text;
                usu.CONTRASENIA = "123";                     // Generar contraseña
                usu.TIPO_USUARIO_ID = 3;                     // 3 Usuario Proveedor
                AddUsuario(usu);
                id_usu = man.ObtenerIDUsuario(txtRut.Text);
                if (id_usu == 0)
                {
                    lbMsg.Text = "Problemas con generación de Usuario";
                }
                else {
                    PROVEEDOR emp = new PROVEEDOR();
                    emp.IDPROVEEDOR = 1;
                    emp.RUT = int.Parse(txtRut.Text);
                    emp.DV = txtDv.Text;  
                    emp.NOMBRE = txtNombre.Text;
                    emp.DIRECCION = txtDireccion.Text;
                    emp.RUBRO = txtRubro.Text;
                    emp.USUARIO_ID = id_usu;
                    AddProveedor(emp);
                    btnCancel.Text = "Salir";
                    lbMsg.Text = "Usuario Creado";
                    txResult.Visible = true;
                    txResult.Text = (" Usuario para el Sistema : " + txtRut.Text + "     \n"+
                                  " Clave para el Sistema   : 123 ");

                }
                
            }
            else
            {
                lbMsg.Text = "Rut Cliente ya Existe";
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
