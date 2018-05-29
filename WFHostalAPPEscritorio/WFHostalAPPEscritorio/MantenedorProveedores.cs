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
using Oracle.DataAccess.Client;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorProveedores : Form
    {
        public MantenedorProveedores()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txRut.Text = "";
            txDv.Text = "";
            txNombre.Text = "";
            txDireccion.Text = "";
            txRubro.Text = "";
            txRut.Enabled = true;
            lbMsg.Text = "";
        }

        public void LlenarGrilla()
        {
            this.dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.ReadOnly = true;
            ManProveedor man = new ManProveedor();
            dgvProveedor.DataSource = man.todosEmpleados();
        }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txRut.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar RUT";
                txRut.Focus();
            }
            else
            {
                try
                {
                    ManProveedor man = new ManProveedor();
                    DataTable dt = man.ProveedorXRut(txRut.Text.Trim());
                    dgvProveedor.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "RUT No existe";
                        dgvProveedor.DataSource = "";
                        txRut.Enabled = true;
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

                            txRut.Text = row[1].ToString();
                            txDv.Text = row[2].ToString();
                            txNombre.Text = row[3].ToString();
                            txDireccion.Text = row[4].ToString();
                            txRubro.Text = row[5].ToString();
                            txRut.Enabled = false;
                            lbMsg.Text = "Rut Encontrado";
                        }

                    }

                }
                catch (Exception ex)
                {
                    lbMsg.Text = "ERROR: " + ex;

                }

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void MantenedorProveedores_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }
    }
}
