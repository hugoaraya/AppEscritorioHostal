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
using Oracle.DataAccess.Client;

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorOrdenDePedido : Form
    {
        public MantenedorOrdenDePedido()
        {
            InitializeComponent();
        }

        public void LlenarGrilla()
        {
            this.dgvOP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOP.MultiSelect = false;
            this.dgvOP.ReadOnly = true;
            ManOrdenPedido man = new ManOrdenPedido();
            dgvOP.DataSource = man.todasOPedido();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNOP.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar NÚMERO OP";
                txtNOP.Focus();
            }
            else
            {
                try
                {
                    ManOrdenPedido man = new ManOrdenPedido();
                    DataTable dt = man.OPXNumero(txtNOP.Text.Trim());
                    dgvOP.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "ORDEN DE PEDIDO No existe";
                        dgvOP.DataSource = "";
                        txtNOP.Enabled = true;
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

                            txtNOP.Text = row[1].ToString();
                            txtNOP.Enabled = false;
                            lbMsg.Text = "OP Encontrada";
                        }

                    }

                }
                catch (Exception ex)
                {
                    lbMsg.Text = "ERROR: " + ex;

                }

            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
