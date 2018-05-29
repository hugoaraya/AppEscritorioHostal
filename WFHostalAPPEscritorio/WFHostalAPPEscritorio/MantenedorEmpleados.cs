using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;
using DAO;

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorEmpleados : Form
    {
        public MantenedorEmpleados()
        {
            InitializeComponent();
        }

        public void LlenarGrilla()
        {
            this.dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.ReadOnly = true;
            ManEmpleado man = new ManEmpleado();
            dgvEmpleados.DataSource = man.todosEmpleados();
        }


        private void MantenedorEmpleados_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            txtApellidoEmp.Text = "";
            txtRut.Enabled = true;
            lblMsg.Text = "";
        }

        

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txtRut.Text) == false)
            {
                lblMsg.Text = ("Ingrese Rut Válido");
                txtRut.Focus();
                return;
            }
            else
            {
                try
                {
                    ManEmpleado man = new ManEmpleado();
                    DataTable dt = man.EmpleadoXRut(APP.ObtenerRut(txtRut.Text));
                    dgvEmpleados.DataSource = dt;
                    if (dt == null)
                    {
                        lblMsg.Text = "RUT No existe";
                        dgvEmpleados.DataSource = "";
                        txtRut.Enabled = true;
                    }
                    else
                    {
                        if (dt.Rows.Count == 0)
                        {
                            return;
                        }
                        else
                        {
                            DataRow row = dt.Rows[0];

                            txtRut.Text = row[0].ToString() + "-" + row[1].ToString();
                            txtNombre.Text = row[2].ToString();
                            txtApellidoEmp.Text = row[3].ToString();
                            txtRut.Enabled = false;
                            lblMsg.Text = "Rut Encontrado";
                        }

                    }

                }
                catch (Exception ex)
                {
                    lblMsg.Text = "ERROR: " + ex;

                }

            }
        }
    

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txtRut.Text) == false || txtRut.Text.Length <= 3)
            {
                lblMsg.Text = ("Ingrese Rut Válido");
                txtRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text) || txtNombre.Text.Length <= 3)
            {
                lblMsg.Text = ("Ingrese la información NOMBRE +4");
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtApellidoEmp.Text))
            {
                lblMsg.Text = ("Ingrese la información APELLIDO");
                txtApellidoEmp.Focus();
                return;
            }

            int pRUT = int.Parse(APP.ObtenerRut(txtRut.Text));
            string pNOMBRE = txtNombre.Text;
            string pAPE = txtApellidoEmp.Text;

            using (EntitiesHostal con = new EntitiesHostal())
            {
                var test = con.EMPLEADO.Where(x => x.RUT == pRUT).FirstOrDefault();
                Console.Write(test);
                Console.Write(test.NOMBRE.ToString());
                test.NOMBRE = pNOMBRE;
                test.APELLIDO = pAPE;
                if (con.SaveChanges() > 0)
                {
                    lblMsg.Text = "Registro Actualizado";

                }
                else
                {
                    Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    lblMsg.Text = "Problemas al actualizar. Revise los datos";

                }
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;
            txtRut.Text = row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString();
            txtNombre.Text = row.Cells[2].Value.ToString();
            txtApellidoEmp.Text = row.Cells[3].Value.ToString();
        }
    }
    
}