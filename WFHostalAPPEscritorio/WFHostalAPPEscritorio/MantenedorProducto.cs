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
    public partial class MantenedorProducto : Form
    {
        public MantenedorProducto()
        {
            InitializeComponent();
        }

        private void MantenedorProducto_Load(object sender, EventArgs e)
        {
           
            LlenarGrilla();
            CargarDatos();


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



        private void CargarDatos()
        {
            ManProducto man = new ManProducto();
            DataTable dtFamilia = man.GetFamiliaProducto();
            if (dtFamilia == null)
            {
                lbMsg.Text = "problema al cargar familia";
            }
            else
            {
                for (int i = 0; i < dtFamilia.Rows.Count; i++)
                {
                    DataRow row = dtFamilia.Rows[i];
                    cbxFamilia.Items.Add(row[1]);
                }
            }
            cbxFamilia.Items.Insert(0, "-Seleccione-");
            cbxFamilia.SelectedIndex = 0;

            DataTable dtTipo = man.GetTipoProducto();
            if (dtTipo == null)
            {
                lbMsg.Text = "problema al cargar Tipo";
            }
            else
            {
                for (int i = 0; i < dtTipo.Rows.Count; i++)
                {
                    DataRow row = dtTipo.Rows[i];
                    cbxTipo.Items.Add(row[1]);
                }
            }
            cbxTipo.Items.Insert(0, "-Seleccione-");
            cbxTipo.SelectedIndex = 0;

            DataTable dtMarca = man.GetMarcaProducto();
            if (dtMarca == null)
            {
                lbMsg.Text = "problema al cargar Marca";
            }
            else
            {
                for (int i = 0; i < dtMarca.Rows.Count; i++)
                {
                    DataRow row = dtMarca.Rows[i];
                    cbxMarca.Items.Add(row[1]);
                }
            }
            cbxMarca.Items.Insert(0, "-Seleccione-");
            cbxMarca.SelectedIndex = 0;
        }


        private void LlenarGrilla()
        {
            this.dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.ReadOnly = true;
            ManProducto man = new ManProducto();
            dgvProductos.DataSource = man.TodosProductos();            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_familia.Text) || tx_familia.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Familia de Producto.");
                tx_familia.Focus();
                return;
            }
            FAMILIA_PRODUCTO fam = new FAMILIA_PRODUCTO();           
            fam.DESCRIPCION = tx_familia.Text;
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.FAMILIA_PRODUCTO.Add(fam);
                con.SaveChanges();
            }
            lbMsg.Text = ("Familia de Producto Ingresada.");
            tx_familia.Text = "";
            CargarDatos();

        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_tipo.Text) || tx_tipo.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Tipo de Producto.");
                tx_tipo.Focus();
                return;
            }
            TIPO_PRODUCTO tip = new TIPO_PRODUCTO();
            tip.DESCRIPCION = tx_tipo.Text;

            try
            {
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    con.TIPO_PRODUCTO.Add(tip);
                    con.SaveChanges();
                }
                lbMsg.Text = ("Tipo de Producto Ingresado.");
                tx_tipo.Text = "";
                CargarDatos();
            }
            catch (Exception ex)
            {
                lbMsg.Text = ("Tipo de Producto No ingresado Reintente.");
                Console.WriteLine("PRODUCTO;;;; "+ex );
                tx_tipo.Focus();
                return;
            } 
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_marca.Text) || tx_marca.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Marca de Producto.");
                tx_marca.Focus();
                return;
            }
            MARCA mar = new MARCA();
            mar.DESCRIPCION = tx_marca.Text;

            try
            {
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    con.MARCA.Add(mar);
                    con.SaveChanges();
                }
                lbMsg.Text = ("Marca de Producto Ingresado.");
                tx_marca.Text = "";
                CargarDatos();
            }
            catch (Exception ex)
            {
                lbMsg.Text = ("Marca de Producto No ingresado Reintente.");
                Console.WriteLine("MARCA;;;; " + ex);
                tx_marca.Focus();
                return;
            }
        }

        private void btnIngresoProd_Click(object sender, EventArgs e)
        {
            ManProducto man = new ManProducto();
            string familia = "";
            string tipo = "";
            string marca = "";
            if (string.IsNullOrEmpty(txPrecioEst.Text))
            {
                lbMsg.Text = ("Ingrese Precio Estimado.");
                txPrecioEst.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSctockCri.Text))
            {
                lbMsg.Text = ("Ingrese Stock Critico.");
                txtSctockCri.Focus();
                return;
            }
            if (cbxFamilia.SelectedIndex == 0)
            {
                lbMsg.Text = ("Seleccione Familia de Producto");
                cbxFamilia.Focus();
                return;
            }
            else
            {
                familia = cbxFamilia.SelectedItem.ToString();
            }
            if (cbxTipo.SelectedIndex == 0)
            {
                lbMsg.Text = ("Seleccione Tipo de Producto");
                cbxTipo.Focus();
                return;
            }
            else
            {
                tipo = cbxTipo.SelectedItem.ToString();
            }
            if (cbxMarca.SelectedIndex == 0)
            {
                lbMsg.Text = ("Seleccione Marca de Producto");
                cbxMarca.Focus();
                return;
            }
            else
            {
                marca = cbxMarca.SelectedItem.ToString();
            }

            PRODUCTO prod = new PRODUCTO();
            prod.FAMILIA_PRODUCTO_ID = man.GetIDFamilia(familia);
            prod.TIPO_PRODUCTO_ID = man.GetIDTipo(tipo);
            prod.MARCA_ID = man.GetIDMarca(marca);
            prod.STOCK_CRITICO = int.Parse(txtSctockCri.Text);
            prod.PRECIO = int.Parse(txPrecioEst.Text);
            prod.STOCK = 0;
            prod.CODIGO_BARRA_ID = 1;

            try
            {
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    con.PRODUCTO.Add(prod);
                    con.SaveChanges();
                }
                MessageBox.Show("Producto Ingresado Correctamente");
                lbMsg.Text = ("Producto Ingresado Correctamente.");
                txPrecioEst.Text = "";
                txtSctockCri.Text = "";
                CargarDatos();
                LlenarGrilla();
            }
            catch (Exception ex)
            {
                lbMsg.Text = ("Producto No ingresado Reintente.");
                Console.WriteLine("PRODUCTO;;;; " + ex);
                return;
            }

        }
    }
}
