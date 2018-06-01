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
    public partial class CheckHuesped : Form
    {
        public CheckHuesped()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            ManOrdenCompra man = new ManOrdenCompra();
            if (string.IsNullOrEmpty(txOrdenCom.Text) || txOrdenCom.Text.Length <= 0 || txOrdenCom.Text.Length >= 10)
            {
                lbMsg.Text = ("Ingrese Nro Orden de Compra");
                txOrdenCom.Focus();
                return;
            }
            if (man.validarNroOrden(int.Parse(txOrdenCom.Text)))
            {
                dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(txOrdenCom.Text));
                lbMsg.Text = "ENCONTRADOS";
                return;
            }
            else
            {
                lbMsg.Text = "NOOOOO ENCONTRADOS";
                return;
            }




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

        private void CheckHuesped_Load(object sender, EventArgs e)
        {
            this.dgvCheck.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheck.MultiSelect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txOrdenCom.Text = "";
            dgvCheck.DataSource =
            lbMsg.Text = "";
        }
    }

}
