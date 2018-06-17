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
            lbUsuario.Text += (" "+Global.usuarioKEY[1]);
            dgvProvee.Focus();
        }

        private void GrillaProveedores()
        {
            dgvProvee.Visible = true;
            this.dgvProvee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvee.MultiSelect = false;
            this.dgvProvee.ReadOnly = true;
            this.dgvProvee.AllowUserToAddRows = false;
            this.dgvProvee.AllowUserToDeleteRows = false;
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
            gboxProve.Text = "Proveedor Seleccionado";
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
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
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
            this.dgvProdSelec.ColumnCount = 5;
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
            this.dgvProdSelec.Columns[4].Name = "IDPRODUCTO";

        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex <= -1)
            {
                return;
            }
            
            var row = (sender as DataGridView).CurrentRow;

            //T.DESCRIPCION AS TIPO, F.DESCRIPCION AS FAMILIA, M.DESCRIPCION AS MARCA, P.STOCK, P.STOCK_CRITICO, P.IDPRODUCTO "
            //row.Cells[0].Value.ToString()
            int rowEscribir = dgvProdSelec.Rows.Count - 1;
            dgvProdSelec.Rows.Add(1);
            //INGRESAR CANTIDAD
            if (Convert.ToInt32(row.Cells[3].Value) < Convert.ToInt32(row.Cells[4].Value))
            {
                dgvProdSelec.Rows[rowEscribir].Cells[0].Value = Convert.ToInt32(row.Cells[4].Value) - Convert.ToInt32(row.Cells[3].Value);
            }
            else
            {
                dgvProdSelec.Rows[rowEscribir].Cells[0].Value = 0;
            }
            dgvProdSelec.Rows[rowEscribir].Cells[1].Value = row.Cells[0].Value.ToString();
            dgvProdSelec.Rows[rowEscribir].Cells[2].Value = row.Cells[1].Value.ToString();
            dgvProdSelec.Rows[rowEscribir].Cells[3].Value = row.Cells[2].Value.ToString();
            dgvProdSelec.Rows[rowEscribir].Cells[4].Value = row.Cells[5].Value.ToString();

            MessageBox.Show("Confirme la Cantidad de Productos");
            lbMsg.Text = "Confirme la Cantidad de Productos";
            btnGenerarOC.Visible = true;
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

        private void btnGenerarOC_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvProdSelec.RowCount.ToString());

            if (dgvProdSelec.RowCount > 1)
            {
                for( int i= 0; i <=  (dgvProdSelec.RowCount -2); i++)
                {
                    int valor = Convert.ToInt32(dgvProdSelec.Rows[i].Cells[0].Value);

                    if ( valor == 0 ) 
                    {
                        MessageBox.Show("Ingrese valor de Cantidad mayor a 0");
                        Console.WriteLine("valor = "+ valor+ "dgv" + dgvProdSelec.Rows[i].Cells[0].Value);
                        return;
                    }
                }
                GenerarOrdenDePedido();
                GenerarRecepcionProducto();
                txResult.Visible = true;
                txResult.Text = "\r\n \r\n \r\n \r\n";
                txResult.Text += "Informar a Proveedor  " + txNombreProvee.Text + "\r\n \r\n";
                txResult.Text += "Se genero la Orden de Pedido Nro: "+ txNroOrden.Text +"\r\n \r\n";

                //txResult.Text += ("     Usuario: " + APP.ObtenerRut(txRut.Text) + "\r\n" +
                //                  "     Clave: " + APP.GenerarClave(txNombre.Text, txRut.Text)) + "\r\n \r\n";
                //txResult.Text += "Lo invitamos a disfrutar de nuestros Servicios.\r\n";
                //txResult.Text += "Ingrese a www.HostalDonaClarita.cl \r\n \r\n \r\n";
                //txResult.Text += "Saludos. Hostal Doña Clarita\r\n \r\n \r\n";
                //txResult.Text += "**Enviar datos a " + txCorreo.Text;
                MessageBox.Show("Orden de Pedido Nro: " + txNroOrden.Text);
            }
            else
            {
                MessageBox.Show("Ingrese Productos");
                dgvProductos.Focus();
            };
        }

     

        private void GenerarOrdenDePedido()
        {
            ManOrdenPedido manOP = new ManOrdenPedido();
            ORDEN_PEDIDO OP = new ORDEN_PEDIDO();
            OP.NRO_ORDEN = manOP.get_NRO_ORDEN_Nuevo();
            txNroOrden.Text = OP.NRO_ORDEN.ToString();
            int idEmpleado = manOP.GetIdEmpleado(int.Parse(Global.usuarioKEY[0]));
            OP.EMPLEADO_ID = idEmpleado;
            Console.WriteLine(" OP.EEMPLEADO_ID " + OP.EMPLEADO_ID);
            OP.FECHA = DateTime.Today;
            Console.WriteLine(" OP.FECHA " + OP.FECHA);
            ManProveedor manP = new ManProveedor();
            String rut = txRutProvee.Text;
            OP.PROVEEDOR_ID = manP.ObtenerIDProveedor(rut.Substring(0, rut.Length - 2));
            OP.ESTADO_ORDEN_PEDIDO_ID = 1; //estado PENDIENTE
            Console.WriteLine("OP.NRO_ORDEN = "+ OP.NRO_ORDEN);
            Console.WriteLine(" OP.EMPLEADO_ID = " + OP.EMPLEADO_ID);
            Console.WriteLine(" OP.PROVEEDOR_ID = " + OP.PROVEEDOR_ID);
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.ORDEN_PEDIDO.Add(OP);
                con.SaveChanges();
            }
            btnGenerarOC.Visible = false;
            dgvProdSelec.ReadOnly = true;
            dgvProductos.Visible = false;
            lblProductosSel.Text = "Productos Seleccionados";
            txGrilla.Text = "DATOS CONFIRMACION:";
            lblpro.Visible = false;
            lbMsg.Text = "Orden de Pedido Registrada Correctamente.";
        }

      

        private void GenerarRecepcionProducto()
        {
            ManOrdenPedido man = new ManOrdenPedido();
            int nroRecepcion = man.get_NRO_RECEPCION_Nuevo();
            for (int i = 0; i <= (dgvProdSelec.RowCount - 2); i++)
            {
                RECEPCION_PRODUCTO RecProd = new RECEPCION_PRODUCTO();
                RecProd.NRO_RECEPCION = nroRecepcion;
                RecProd.PRODUCTO_ID = Convert.ToInt32(dgvProdSelec.Rows[i].Cells[4].Value);
                RecProd.ESTADO_RECEPCION_ID = 1;
                RecProd.ORDEN_PEDIDO_ID = man.GetIdOrdenPedido(txNroOrden.Text);
                //RecProd.FECHA = NULL;
                RecProd.CANTIDAD_P = Convert.ToInt32(dgvProdSelec.Rows[i].Cells[0].Value);
                //Console.WriteLine("0- "+RecProd.NRO_RECEPCION);
                //Console.WriteLine("1- " + RecProd.PRODUCTO_ID);
                //Console.WriteLine("2- " + RecProd.ESTADO_RECEPCION_ID); 
                //Console.WriteLine("3- " + RecProd.ORDEN_PEDIDO_ID); 
                //Console.WriteLine("4- " + RecProd.CANTIDAD_P);
                AddRecepcionProducto(RecProd);
            }
           

        }
        public void AddRecepcionProducto(RECEPCION_PRODUCTO rp)
        {
            try
            {
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    con.RECEPCION_PRODUCTO.Add(rp);
                    con.SaveChanges();
                }
                lbMsg.Text = "Orden de Pedido Registrada Correctamente. (Recepcion de Producto Pendiente)";
            }
            catch {
                Console.WriteLine("Error por fila de DataGridView");
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
