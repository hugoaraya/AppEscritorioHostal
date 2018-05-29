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
            if (APP.validarRut(txtNOP.Text) == false)
            {
                lbMsg.Text = ("Ingrese Rut Válido");
                txtNOP.Focus();
                return;
            }
            else
            {
                try
                {
                    ManOrdenPedido man = new ManOrdenPedido();
                    DataTable dt = man.OPXNumero(APP.ObtenerRut(txtNOP.Text));
                    dgvOP.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "RUT No existe";
                        dgvEmpresa.DataSource = "";
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

                            txRut.Text = row[0].ToString() + "-" + row[1].ToString();
                            txNombre.Text = row[2].ToString();
                            txDireccion.Text = row[3].ToString();
                            txTelefono.Text = row[4].ToString();
                            txCorreo.Text = row[5].ToString();
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
