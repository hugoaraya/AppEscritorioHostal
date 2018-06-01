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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
