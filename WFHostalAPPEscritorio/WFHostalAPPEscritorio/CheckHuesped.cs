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

        public string _pRut;
        public string PRut
        {
            get
            {
                return _pRut;
            }

            set
            {
                _pRut = value;
            }
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
            PRut = "";
        }

        private void dgvCheck_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ManOrdenCompra man = new ManOrdenCompra();
            if (e.RowIndex <= -1)
            {
                return;
            }
            var row = (sender as DataGridView).CurrentRow;

            //E.ESTADO , U.RUT, U.DV, U.NOMBRE,U.APELLIDO,M.NOMBRE AS EMPRESA, O.NRO_ORDEN
            PRut = row.Cells[1].Value.ToString();
            Console.Write("LOG HUGO PRut:" + row.Cells[1].Value.ToString());
            string pNroOrden = row.Cells[6].Value.ToString();
            if (PRut == "")
            {
                return;
            }
            DataTable data = new DataTable();
            data = man.getOCHuesped(pNroOrden, PRut);
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
                txOrdenCom.ReadOnly = true;
                lbMsg.Text = "Seleccione Ingreso o Salida del Huesped";
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txOrdenCom.Text = "";
            dgvCheck.DataSource = "";
            txDatosHue.Text = "";
            txDatosHue.Visible = false;
            txOrdenCom.ReadOnly = false;
            lbMsg.Text = "";
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {

            ManOrdenCompra man = new ManOrdenCompra();
            string pNroOrden = txOrdenCom.Text;
            if (PRut == "" || pNroOrden == "")
            {
                lbMsg.Text = "Seleccione un Huesped";
                return;
            }
            DataTable data = new DataTable();
            Console.Write("LOG HUGO pNroOrden:" + pNroOrden);
            Console.Write("LOG HUGO PRut:" + PRut);
            data = man.getID_OCHuesped(pNroOrden, PRut);
            if (data.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DataRow rows = data.Rows[0];
                //0.IDORDEN_COMPRA ,1.IDHUESPED_HABITACION, 2.IDHUESPED, 3.IDESTADO_HUESPED, 4.IDEMPRESA, 
                //5.IDHABITACION,6.IDESTADO_HABITACION,7.IDFECHAS_RESERVAS,8.IDORDEN_COMEDOR,9.IDSERVICIO,
                //10.IDPLATO,11.IDSERVICIO txDatosHue.Visible = true;
                int pIDHUESPED = int.Parse(rows[2].ToString());
                int pIDHABITACION = int.Parse(rows[5].ToString());
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    var test = con.HUESPED.Where(x => x.IDHUESPED == pIDHUESPED).FirstOrDefault();
                    test.ESTADO_HUESPED_ID = 1; //--HOSPEDADO
                    if (con.SaveChanges() > 0)
                    {
                        PRut = "";
                        lbMsg.Text = "Estado Huesped Actualizado.";
                        txDatosHue.Text = "";
                        dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(pNroOrden));
                    }
                    else
                    {
                        Console.Write("LOG HUGO: PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                        lbMsg.Text = "Problemas al actualizar. Revise los datos";
                        dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(pNroOrden));
                        return;
                    }

                    //var test2 = con.HABITACION.Where(x => x.IDHABITACION == pIDHABITACION).FirstOrDefault();
                    //Console.Write(test2);
                    //Console.Write(test2.ESTADO_HABITACION_ID.ToString());
                    //test2.ESTADO_HABITACION_ID = 2; //--Ocupada
                    //if (con.SaveChanges() > 0)
                    //{
                    //    PRut = "";
                    //    dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(pNroOrden));
                    //    lbMsg.Text = "Estado Huesped y Habitacion Actualizado";
                    //    txDatosHue.Visible = false;
                    //}
                    //else
                    //{
                    //    Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    //    lbMsg.Text = "Problemas al actualizar. Revise los datos";
                    //    return;

                    //}
                }
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            ManOrdenCompra man = new ManOrdenCompra();
            string pNroOrden = txOrdenCom.Text;
            if (PRut == "" || pNroOrden == "")
            {
                lbMsg.Text = "Seleccione un Huesped";
                return;
            }
            DataTable data = new DataTable();
            Console.Write("LOG HUGO SAL pNroOrden:" + pNroOrden);
            Console.Write("LOG HUGO SAL PRut:" + PRut);
            data = man.getID_OCHuesped(pNroOrden, PRut);
            if (data.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DataRow rows = data.Rows[0];
                //0.IDORDEN_COMPRA ,1.IDHUESPED_HABITACION, 2.IDHUESPED, 3.IDESTADO_HUESPED, 4.IDEMPRESA, 
                //5.IDHABITACION,6.IDESTADO_HABITACION,7.IDFECHAS_RESERVAS,8.IDORDEN_COMEDOR,9.IDSERVICIO,
                //10.IDPLATO,11.IDSERVICIO txDatosHue.Visible = true;
                int pIDHUESPED = int.Parse(rows[2].ToString());
                int pIDHABITACION = int.Parse(rows[5].ToString());

                using (EntitiesHostal con = new EntitiesHostal())
                {
                    var test = con.HUESPED.Where(x => x.IDHUESPED == pIDHUESPED).FirstOrDefault();
                    Console.Write(test);
                    Console.Write(test.ESTADO_HUESPED.ToString());
                    test.ESTADO_HUESPED_ID = 2; //--CHECKOUT
                    if (con.SaveChanges() > 0)
                    {
                        PRut = "";
                        lbMsg.Text = "Estado Huesped Actualizado";
                        dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(pNroOrden));
                        txDatosHue.Text = "";
                    }
                    else
                    {
                        Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                        lbMsg.Text = "Problemas al actualizar. Revise los datos";
                        return;
                    }

                    //var test2 = con.HABITACION.Where(x => x.IDHABITACION == pIDHABITACION).FirstOrDefault();
                    //Console.Write(test2);
                    //Console.Write(test2.ESTADO_HABITACION_ID.ToString());
                    //test2.ESTADO_HABITACION_ID = 1; //--Diponible
                    //if (con.SaveChanges() > 0)
                    //{
                    //    PRut = "";
                    //    dgvCheck.DataSource = man.GetOrdenesxNro(int.Parse(pNroOrden));
                    //    lbMsg.Text = "Estado Huesped y Habitacion Actualizado";
                    //    txDatosHue.Visible = false;
                    //}
                    //else
                    //{
                    //    Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    //    lbMsg.Text = "Problemas al actualizar. Revise los datos";
                    //    return;

                    //}
                }
            }
        }
    }
}
