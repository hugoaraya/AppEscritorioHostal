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
    public partial class Ingresar_Empleado : Form
    {
        public void AddUsuario(USUARIO usu)

        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.USUARIO.Add(usu);
                con.SaveChanges();
            }
        }

        public void AddEmpleado(EMPLEADO emp)
        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.EMPLEADO.Add(emp);
                con.SaveChanges();
            }
            btnIngresar.Visible = false;
        }

        public Ingresar_Empleado()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)

        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txtRutEmp.Text) == false || txtRutEmp.Text.Length <= 3)
            {
                lblMsg.Text = ("Debe completar la información RUT");
                txtRutEmp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombreEmp.Text) || txtNombreEmp.Text.Length <= 3)
            {
                lblMsg.Text = ("Debe completar la información NOMBRE");
                txtNombreEmp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtApellidoEmp.Text))
            {
                lblMsg.Text = ("Debe completar la información APELLIDO");
                txtApellidoEmp.Focus();
                return;
            }

            int id_empl = 0;
            ManEmpleado man = new ManEmpleado();
            
            if (man.validarRutEmpleado(APP.ObtenerRut(txtRutEmp.Text)))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = APP.ObtenerRut(txtRutEmp.Text);
                usu.CONTRASENIA = APP.GenerarClave(txtNombreEmp.Text, txtRutEmp.Text);
                usu.TIPO_USUARIO_ID = 4; // 4 Cliente Empleado
                AddUsuario(usu);
                id_empl = man.ObtenerIDUsuario(APP.ObtenerRut(txtRutEmp.Text));
                if (id_empl == 0)
                {
                    lblMsg.Text = "Problemas con generación de Usuario";
                }
                else
                {
                    EMPLEADO emp = new EMPLEADO();
                    emp.IDEMPLEADO = 1;
                    emp.RUT = int.Parse(APP.ObtenerRut(txtRutEmp.Text));
                    emp.DV = APP.GenerarDV(APP.ObtenerRut(txtRutEmp.Text));
                    emp.NOMBRE = txtNombreEmp.Text;
                    emp.APELLIDO = txtApellidoEmp.Text;
                    emp.USUARIO_ID = id_empl;
                    AddEmpleado(emp);
                    btnCancel.Text = "Salir";
                    lblMsg.Text = "Empleado Creado";
                    txResult.Visible = true;
                    txResult.Text += "Estimado/a " + txtNombreEmp.Text + "\r\n \r\n";
                    txResult.Text += "Estos son sus datos para poder acceder a nuestro Sistema.\r\n \r\n";
                    txResult.Text += ("     Usuario: " + APP.ObtenerRut(txtRutEmp.Text) + "\r\n" +
                                      "     Clave: " + APP.GenerarClave(txtNombreEmp.Text, txtRutEmp.Text)) + "\r\n \r\n";


                    txResult.Text += "Hostal Doña Clarita\r\n \r\n \r\n";

                    txResult.Text += "**Informar datos al Empleado";

                }

            }
            else
            {
                lblMsg.Text = "Rut Empleado ya Existe";
                txtRutEmp.Focus();
                return;
            }

        }
    }
   
}
