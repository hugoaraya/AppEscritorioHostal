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
            if (string.IsNullOrEmpty(txOrdenCom.Text) || txOrdenCom.Text.Length <= 0 || txOrdenCom.Text.Length >= 10 || txOrdenCom.Text.Trim() == "")
            {
                lbMsg.Text = ("Ingrese o corrija el Nro Orden de Compra");
                txOrdenCom.Focus();
                return;
            }
            if (man.validarNroOrden(int.Parse(txOrdenCom.Text)))
            {
                dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(txOrdenCom.Text));
                lbMsg.Text = "Orden de compra encontrada";
                return;
            }
            else
            {
                lbMsg.Text = "Orden de compra No encontrada";
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
            this.dgvCheck.ReadOnly = true;
        }


        private void dgvCheck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManOrdenCompra man = new ManOrdenCompra();
            if (e.RowIndex <= -1)
            {
                return;
            }
            var row = (sender as DataGridView).CurrentRow;

            //E.ESTADO AS ESTADO, U.RUT, U.DV, U.NOMBRE,U.APELLIDO,M.NOMBRE AS EMPRESA, O.NRO_ORDEN

            string pRut = row.Cells[1].Value.ToString();
            string pNroOrden = row.Cells[6].Value.ToString();
            if (pRut == "")
            {
                return;
            }
            DataTable data = new DataTable();
            data = man.getOCHuesped(pNroOrden, pRut);
            //Console.;
            if (data.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DataRow rows = data.Rows[0];
                //0.ESTADO, 1.RUT, 2.DV, 3.NOMBRE,4.APELLIDO,5.NOMBRE_EMPRESA, 6.NRO_ORDEN, 7.DESCRIPCION AS HABITACION,
                //8.FECHA_INGRESO, 9.FECHA_SALIDA,10.DESCRIPCION AS SERVICIO,11.NOMBRE_MINUTA,12.NOMBRE_PLATO 
                txDatosHue.Visible = true;
                txDatosHue.Text = "\r\n";
                txDatosHue.Text += "Nro OC : " + rows[6].ToString() + "\r\n";
                txDatosHue.Text += "Empresa : " + rows[5].ToString() + "\r\n";
                txDatosHue.Text += "\r\n \r\n";
                txDatosHue.Text += "RUT : " + rows[1].ToString() + "-" + rows[2].ToString() + "\r\n";
                txDatosHue.Text += "Nombre : " + rows[3].ToString() + " " + rows[4].ToString() + "\r\n \r\n";
                txDatosHue.Text += "\r\n \r\n";
                txDatosHue.Text += "Habitacion : " + rows[7].ToString() + "\r\n";
                txDatosHue.Text += "Comedor : " + rows[10].ToString() + "\r\n";
                txDatosHue.Text += "\r\n \r\n";
                txDatosHue.Text += "Fecha Ingreso : " + rows[8].ToString() + "\r\n";
                txDatosHue.Text += "Fecha Salida : " + rows[9].ToString() + "\r\n \r\n";
                txDatosHue.Text += "\r\n \r\n";
                txDatosHue.Text += "Estado Huesped : " + rows[0].ToString();
                
                lbMsg.Text = "Seleccione Ingreso o Salida del Huesped";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txOrdenCom.Text = "";
            dgvCheck.DataSource = "";
            txDatosHue.Text = "";
            txDatosHue.Visible = false;
            lbMsg.Text = "";
        }
    }

}
