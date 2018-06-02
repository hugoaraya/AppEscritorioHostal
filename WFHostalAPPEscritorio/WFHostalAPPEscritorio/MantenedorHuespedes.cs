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
    public partial class MantenedorHuespedes : Form
    {
        public MantenedorHuespedes()
        {
            InitializeComponent();
        }

        public void llenarGrilla()
        {
            ManHuesped man = new ManHuesped();
            dgvHuesped.DataSource = man.TodosHuepedes();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txRut.Text))
            {
                lbMsg.Text = ("Debe completar la informacion RUT");
                txRut.Focus();
                return;
            }
            try
            {
                ManHuesped man = new ManHuesped();
                DataTable dt = man.UnHueped(txRut.Text.Trim());
                dgvHuesped.DataSource = dt;
                if (dt == null)
                {
                    lbMsg.Text = "Huesped No existe";
                    dgvHuesped.DataSource = "";
                    txRut.Enabled = true;
                    txRut.Focus();

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
                        txRut.Text = row[0].ToString();
                        txNombre.Text = row[2].ToString();
                        txApellido.Text = row[3].ToString();
                        txTelefono.Text = row[4].ToString();
                        txCorreo.Text = row[5].ToString();
                        txCargo.Text = row[6].ToString();
                        txRutEmp.Text = row[7].ToString();
                        lbMsg.Text = "Heusped Encontrado";
                        txRut.Enabled = false;

                    }

                }

            }
            catch (Exception ex)
            {
                lbMsg.Text = "ERROR: " + ex;

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void MantenedorHuespedes_Load(object sender, EventArgs e)
        {
            this.dgvHuesped.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHuesped.MultiSelect = false;
            this.dgvHuesped.ReadOnly = true;
            llenarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        public void LimpiarDatos()
        {
            txRut.Text = "";
            txNombre.Text = "";
            txApellido.Text = "";
            txTelefono.Text = "";
            txCorreo.Text = "";
            txCargo.Text = "";
            txRutEmp.Text = "";
            llenarGrilla();
            txRut.Focus();
            txRut.Enabled = true;
            lbMsg.Text = "";
            txRut.ReadOnly = false;
            txRutEmp.ReadOnly = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHuesped_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;
            //0.RUT,1.DV,2.NOMBRE,3.APELLIDO,4.TELEFONO,5.CORREO,6.CARGO,7.RUT AS RUT_EMPRESA
            txRut.Text = row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString();
            txNombre.Text = row.Cells[2].Value.ToString();
            txApellido.Text = row.Cells[3].Value.ToString();
            txTelefono.Text = row.Cells[4].Value.ToString();
            txCorreo.Text = row.Cells[5].Value.ToString();
            txCargo.Text = row.Cells[6].Value.ToString();
            txRutEmp.Text = row.Cells[7].Value.ToString() + "-" + row.Cells[8].Value.ToString();
            txRut.ReadOnly = true;
            txRutEmp.ReadOnly = true;
        }

        private void btnXRut_Click(object sender, EventArgs e)
        {
            ManHuesped man = new ManHuesped();
            MetodosAPP APP = new MetodosAPP();
            dgvHuesped.DataSource = man.GetHuespedesXRut(APP.ObtenerRut(txRutEmp.Text));
            txRut.ReadOnly = true;
            txRutEmp.ReadOnly = true;
        }
    }
}
