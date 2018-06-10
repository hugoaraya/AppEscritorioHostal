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
using Microsoft.VisualBasic;


namespace WFHostalAPPEscritorio
{
    public partial class IngresoOrdenPedido : Form
    {
        public IngresoOrdenPedido()
        {
            InitializeComponent();
        }

        private void IngresoOrdenPedido_Load(object sender, EventArgs e)
        {
            GrillaProveedores();
            dgvProvee.Focus();
            lbUsuario.Text += (" "+Global.usuarioKEY[1]);
        }
        private void GrillaProveedores()
        {
            dgvProvee.Visible = true;
            this.dgvProvee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvee.MultiSelect = false;
            this.dgvProvee.ReadOnly = true;
            ManOrdenPedido man = new ManOrdenPedido();
            dgvProvee.DataSource = man.ListaProveedor();
            txGrilla.Text = "Seleccione Proveedor (doble click)";
            btnProvee.Visible = false;
        }

        private void dgvProvee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;

            //P.NOMBRE,F.DESCRIPCION AS RUBRO,P.RUT,P.DV

            txRutProvee.Text = row.Cells[2].Value.ToString() + "-" + row.Cells[3].Value.ToString();
            txNombreProvee.Text = row.Cells[0].Value.ToString();
            txRubroProvee.Text = row.Cells[1].Value.ToString();
            btnProvee.Visible = true;
        }

        private void btnProvee_Click(object sender, EventArgs e)
        {
            dgvProvee.Visible = false;
            btnProvee.Visible = false;
            GrillaProductos();
        }

     

        private void GrillaProductos()
        {
            dgvProductos.Visible = true;
            txGrilla.Text = "Seleccione Productos (doble click)";
            this.dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.ReadOnly = true;
            ManOrdenPedido man = new ManOrdenPedido();
            dgvProductos.DataSource = man.ListaProductos();
            GrillaProdSelec();
            lblpro.Visible = true;
        }

        private void GrillaProdSelec()
        {
            dgvProdSelec.Visible = true;
            this.dgvProdSelec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdSelec.MultiSelect = false;
            //this.dgvProdSelec.ReadOnly = true;
            this.dgvProdSelec.ColumnCount = 4;
            this.dgvProdSelec.ColumnHeadersVisible = true;
            this.dgvProdSelec.Columns[0].ReadOnly = false;
            this.dgvProdSelec.Columns[0].ValueType = typeof(Int32);
            this.dgvProdSelec.Columns[0].Name = "CANTIDAD";

            this.dgvProdSelec.Columns[1].ReadOnly = true;
            this.dgvProdSelec.Columns[2].ReadOnly = true;
            this.dgvProdSelec.Columns[3].ReadOnly = true;
            
            this.dgvProdSelec.Columns[1].Name = "TIPO";
            this.dgvProdSelec.Columns[2].Name = "FAMILIA";
            this.dgvProdSelec.Columns[3].Name = "MARCA";

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex <= -1)
            {
                return;
            }
            
            var row = (sender as DataGridView).CurrentRow;
            
            //T.DESCRIPCION AS TIPO, F.DESCRIPCION AS FAMILIA, M.DESCRIPCION AS MARCA, P.STOCK, P.STOCK_CRITICO " +        
            //row.Cells[0].Value.ToString()
            int rowEscribir = dgvProdSelec.Rows.Count - 1;
            dgvProdSelec.Rows.Add(1);
            //INGRESAR CANTIDAD
            dgvProdSelec.Rows[rowEscribir].Cells[0].Value = 0;
            dgvProdSelec.Rows[rowEscribir].Cells[1].Value = row.Cells[0].Value.ToString();
            dgvProdSelec.Rows[rowEscribir].Cells[2].Value = row.Cells[1].Value.ToString();
            dgvProdSelec.Rows[rowEscribir].Cells[3].Value = row.Cells[2].Value.ToString();
            
            MessageBox.Show("Ingrese Cantidad al Producto");
            lbMsg.Text = "Ingrese Cantidad a los Productos";
            dgvProdSelec.Focus();
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

        private void dgvProdSelec_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese un Numero en Cantidad");
        }
    }
}
