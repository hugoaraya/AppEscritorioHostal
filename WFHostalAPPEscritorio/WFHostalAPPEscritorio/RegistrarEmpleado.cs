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
            if (string.IsNullOrEmpty(txtRutEmp.Text))
            {
                lblMsg.Text = ("Debe completar la información RUT");
                txtRutEmp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombreEmp.Text))
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
            MetodosAPP APP = new MetodosAPP();
            if (man.validarRutEmpleado(txtRutEmp.Text))
            {
                USUARIO usu = new USUARIO();
                usu.IDUSUARIO = 1;
                usu.NOMBRE_USUARIO = txtRutEmp.Text;
                usu.CONTRASENIA = "123";                     // generar contraseña
                usu.TIPO_USUARIO_ID = 4;                     // 4 Cliente Empleado
                AddUsuario(usu);
                id_empl = man.ObtenerIDUsuario(txtRutEmp.Text);
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
                    txResult.Text = (" Usuario para el Sistema : " + txtRutEmp.Text +
                                  " Clave para el Sistema   : 123 ");

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
