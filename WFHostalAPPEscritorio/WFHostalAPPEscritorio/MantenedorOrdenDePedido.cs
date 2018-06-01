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
            MetodosAPP APP = new MetodosAPP();
            if (txtNOP.Text.Trim() == "")
            {
                lbMsg.Text = ("Ingrese Número Válido");
                txtNOP.Focus();
            }
            else
            {
                try
                {
                    ManOrdenPedido man = new ManOrdenPedido();
                    DataTable dt = man.OPXNumero(txtNOP.Text);
                    dgvOP.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "NRO DE ORDEN No existe";
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
                            txtNOP.Text = row[0].ToString();
                            row[1].ToString();
                            row[2].ToString();
                            row[3].ToString();
                            row[4].ToString();
                            row[5].ToString();
                            row[6].ToString();
                            row[7].ToString(); 
                            txtNOP.Enabled = false;
                            lbMsg.Text = "ODP Encontrada";
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

        private void MantenedorOrdenDePedido_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

       
    }
}
