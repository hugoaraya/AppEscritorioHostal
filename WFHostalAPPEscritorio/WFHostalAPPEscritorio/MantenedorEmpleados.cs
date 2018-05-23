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
            ManEmpresa man = new ManEmpresa();
            dgvEmpleados.DataSource = man.todasEmpresas();
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
        }

        

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtRut.Text.Trim() == "")
            {
                lblMsg.Text = "Asegúrese de ingresar RUT sin DV";
                txtRut.Focus();
            }
            else
            {
                try
                {
                    ManEmpleado man = new ManEmpleado();
                    DataTable dt = man.EmpleadoXRut(txtRut.Text.Trim());
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

                            txtRut.Text = row[1].ToString();
                            txtNombre.Text = row[3].ToString();
                            txtApellidoEmp.Text = row[4].ToString();
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

        }
    }
}