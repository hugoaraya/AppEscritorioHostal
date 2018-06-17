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
    public partial class RecepcionarODP : Form
    {
        public RecepcionarODP()
        {
            InitializeComponent();
        }

        private void btnBuscarODP_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (txODP.Text.Trim() == "")
            {
                lbMsg.Text = ("Ingrese Número de Orden válido");
                txODP.Focus();
            }
            else
            {
                try
                {
                    ManOrdenPedido man = new ManOrdenPedido();
                    DataTable dt = man.OPXNumero(txODP.Text);

                    //dgvODP.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "Nro de Orden No existe";
                        dgvODP.DataSource = "";
                        txODP.Enabled = true;
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
                            // 0= OP.ESTADO_ORDEN_PEDIDO_ID AS ESTADO, EO.DESCRIPCION, OP.IDORDEN_PEDIDO AS ID_ODP, OP.NRO_ORDEN, OP.EMPLEADO_ID, E.NOMBRE AS EMPLEADO, OP.FECHA, OP.PROVEEDOR_ID, P.RUT , P.DV, P.NOMBRE AS PROVEEDOR, OP.COMENTARIO " +
                            if (int.Parse(row[0].ToString()) == 2)
                            {
                                txODP.Text = row[3].ToString();
                                txODP.ReadOnly = true;
                                lbEstado.Text = "  " + row[1].ToString();
                                lbProveedor.Text = "  " + row[10].ToString();
                                lbIdODP.Text = row[2].ToString();
                                lbMsg.Text = "ODP Encontrada";
                                btnBuscarODP.Visible = false;

                                this.dgvODP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                this.dgvODP.MultiSelect = false;
                                this.dgvODP.ReadOnly = true;
                                this.dgvODP.AllowUserToAddRows = false;
                                this.dgvODP.AllowUserToDeleteRows = false;
                                dgvODP.DataSource = man.GetRecepcionProdXidPedido(lbIdODP.Text);
                                lblGrilla.Text = "Seleccione Producto (doble click)";
                                lbMsg.Text = "ODP Encontrada";
                                btnBuscarODP.Visible = false;

                            }
                            else if (int.Parse(row[0].ToString()) == 1)
                            {
                                lbEstado.Text = "  " + row[1].ToString();
                                lbProveedor.Text = "  " + row[10].ToString();
                                MessageBox.Show("ODP con Estado Pendiente - Confirme Situación");
                                lbMsg.Text = "ODP con Estado Pendiente - Confirme Situación";
                            }
                            else if (int.Parse(row[0].ToString()) == 3)
                            {
                                lbEstado.Text = "  " + row[1].ToString();
                                lbProveedor.Text = "  " + row[10].ToString();
                                MessageBox.Show("ODP con Estado Rechazado - Confirme Situación");
                                lbMsg.Text = "ODP con Estado Rechazado - Confirme Situación";
                            }
                            else
                            {
                                lbMsg.Text = "ODP no encontrada - Confirme Situación";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lbMsg.Text = "ERROR: " + ex;
                }
            }
        }

        private void dgvODP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManOrdenPedido man = new ManOrdenPedido();
            if (e.RowIndex <= -1)
            {
                return;
            }
            var row = (sender as DataGridView).CurrentRow;

            //ER.DESCRIPCION AS ESTADO,CB.CODIGO AS CODIGO_BARRA,P.IDPRODUCTO AS ID_PROD, TP.DESCRIPCION,RP.CANTIDAD_P,RP.NRO_RECEPCION,RP.IDRECEPCION_PRODUCTO AS ID_RECEP " +
            //row.Cells[1].Value.ToString()
            if (int.Parse(row.Cells[7].Value.ToString()) ==  2)
            {
                lbMsg.Text = "Seleccione Producto con estado Pendiente";
                MessageBox.Show("Producto ya Recepcionado - Seleccione Otro");
                return;
            }
            lbIDProd.Text = row.Cells[2].Value.ToString();
            lbCodigoBarra.Text = row.Cells[1].Value.ToString();
            lbDescripc.Text = row.Cells[3].Value.ToString();
            lbCantidad.Text = row.Cells[4].Value.ToString();
            lbIDRecep.Text = row.Cells[6].Value.ToString();
            MessageBox.Show("Confirme Cantidad de Productos e Ingrese Fecha de Vencimiento");
            gbProd.Visible = true;
            btnConfirmar.Visible = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txODP.ReadOnly = false;
            txODP.Text = "";
            btnBuscarODP.Visible = true;
            lbProveedor.Text = "";
            lbEstado.Text = "";
            lbMsg.Text = "";
            dgvODP.DataSource = "";
            gbProd.Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ManOrdenPedido man = new ManOrdenPedido();
            if (dtiVencimiento.Value < DateTime.Now)
            {
                MessageBox.Show("Fecha Vencimiento debe ser mayor a la Fecha actual");
                lbMsg.Text = "Fecha Vencimiento debe ser mayor a la Fecha actual";
                return;
            }
            else
            {
                ActualizarRecepcionProducto();
                btnConfirmar.Visible = false;
                dgvODP.DataSource = man.GetRecepcionProdXidPedido(lbIdODP.Text);
                lbCodigoBarra.Text = "";
                lbCantidad.Text = "";
                lbIDProd.Text = "";
                lbDescripc.Text = "";
                dtiVencimiento.Value = DateTime.Now;
                lbMsg.Text = "Producto Recepcionado - Seleccione otro Producto";
                MessageBox.Show("Producto Recepcionado");
            }
        }
        private void ActualizarRecepcionProducto()
        {
            Console.WriteLine("lbIDRecep.Text " + lbIDRecep.Text);
            int idRecep = int.Parse(lbIDRecep.Text);
            using (EntitiesHostal con = new EntitiesHostal())
            {
                var UpRecepProd = con.RECEPCION_PRODUCTO.Where(x => x.IDRECEPCION_PRODUCTO == idRecep).FirstOrDefault();
                UpRecepProd.ESTADO_RECEPCION_ID = 2; //Cerrada
                UpRecepProd.FECHA = DateTime.Now;
                
                if (con.SaveChanges() > 0)
                {
                    lbMsg.Text = "Estado Recepcion Actualizado.";
                }
                else
                {
                    Console.Write("LOG RECEP: PREOBLEMAS AL ACTUALIZAR DATOS_:");
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";
                    return;
                }
            }

            int IdProd = int.Parse(lbIDProd.Text);
            using (EntitiesHostal con2 = new EntitiesHostal())
            {
                var test = con2.PRODUCTO.Where(x => x.IDPRODUCTO == IdProd).FirstOrDefault();
                test.STOCK = test.STOCK + int.Parse(lbCantidad.Text);
                test.FECHA_VENCIMIENTO = dtiVencimiento.Value;
                if (con2.SaveChanges() > 0)
                {
                    lbMsg.Text = "STOCK y Fecha Vencimiento Producto Actualizado.";
                }
                else
                {
                    Console.Write("LOG RECEP PROD: PREOBLEMAS AL ACTUALIZAR DATOS_:");
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";
                    return;
                }
            }
            ManOrdenPedido man = new ManOrdenPedido();
            CODIGO_BARRA cbProd = new CODIGO_BARRA();
            Console.WriteLine("RE.::: "+man.SetCodigoBarra(lbIDRecep.Text));
            Int64 dbText = Int64.Parse(man.SetCodigoBarra(lbIDRecep.Text));
            var CodigoBarra = dbText;
            cbProd.CODIGO = CodigoBarra;
            using (EntitiesHostal con4 = new EntitiesHostal())
            {
                con4.CODIGO_BARRA.Add(cbProd);
                con4.SaveChanges();
            }


            using (EntitiesHostal con3 = new EntitiesHostal())
            {
                var test2 = con3.PRODUCTO.Where(x => x.IDPRODUCTO == IdProd).FirstOrDefault();
                test2.CODIGO_BARRA_ID = man.GetIdCodBarra(CodigoBarra);
                if (con3.SaveChanges() > 0)
                {
                    lbMsg.Text = "Codigo Barra Actualizado.";
                }
                else
                {
                    Console.Write("LOG RECEP CODIGO BARRA: PREOBLEMAS AL ACTUALIZAR DATOS_:" );
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";
                    return;
                }
            }


        }
    }
}
