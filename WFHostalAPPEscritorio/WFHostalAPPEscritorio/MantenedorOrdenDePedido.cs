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
            //this.dgvOP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.dgvOP.MultiSelect = false;
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
                            // 0= OP.ESTADO_ORDEN_PEDIDO_ID AS ESTADO, EO.DESCRIPCION, OP.IDORDEN_PEDIDO AS ID_ODP, OP.NRO_ORDEN, OP.EMPLEADO_ID, E.NOMBRE AS EMPLEADO, OP.FECHA, OP.PROVEEDOR_ID, P.RUT , P.DV, P.NOMBRE AS PROVEEDOR, OP.COMENTARIO " +
                            DataRow row = dt.Rows[0];
                            //row[0].ToString();
                            //row[1].ToString();
                            //row[2].ToString();
                            //row[3].ToString();
                            //row[4].ToString();
                            //row[5].ToString();
                            //row[6].ToString();
                            //row[7].ToString(); 
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbMsg.Text = "";
            dgvOP.DataSource = "";
            txtNOP.Text = "";
            txtNOP.Enabled = true;

        }

        private void btnAceptadas_Click(object sender, EventArgs e)
        {
            ManOrdenPedido man = new ManOrdenPedido();
            DataTable dt = man.OPXEstado(2);
            dgvOP.DataSource = dt;
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            ManOrdenPedido man = new ManOrdenPedido();
            DataTable dt = man.OPXEstado(1);
            dgvOP.DataSource = dt;

        }

        private void btnRechazadas_Click(object sender, EventArgs e)
        {
            ManOrdenPedido man = new ManOrdenPedido();
            DataTable dt = man.OPXEstado(3);
            dgvOP.DataSource = dt;
        }
    }

}