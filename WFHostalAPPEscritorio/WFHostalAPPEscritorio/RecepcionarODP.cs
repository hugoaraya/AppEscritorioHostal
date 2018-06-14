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
                lbMsg.Text = ("Ingrese Número válido");
                txODP.Focus();
            }
            else
            {
                try
                {
                    ManOrdenPedido man = new ManOrdenPedido();
                    DataTable dt = man.OPXNumero(txODP.Text);
                    dgvODP.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "NRO DE ORDEN No existe";
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
                            txODP.Text = row[0].ToString();
                            row[1].ToString();
                            row[2].ToString();
                            row[3].ToString();
                            row[4].ToString();
                            //row[5].ToString();
                            //row[6].ToString();
                            //row[7].ToString();
                            txODP.Enabled = false;
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

        private void dgvODP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
    //        ManOrdenPedido man = new ManOrdenPedido();
    //        if (e.RowIndex <= -1)
    //        {
    //            return;
    //        }
    //        var row = (sender as DataGridView).CurrentRow;

    //        //E.ESTADO , U.RUT, U.DV, U.NOMBRE,U.APELLIDO,M.NOMBRE AS EMPRESA, O.NRO_ORDEN
    //        PRut = row.Cells[1].Value.ToString();
    //        Console.Write("LOG HUGO PRut:" + row.Cells[1].Value.ToString());
    //        string pNroOrden = row.Cells[6].Value.ToString();
    //        if (PRut == "")
    //        {
    //            return;
    //        }
    //        DataTable data = new DataTable();
    //        data = man.getOCHuesped(pNroOrden, PRut);
    //        if (data.Rows.Count == 0)
    //        {
    //            return;
    //        }
    //        else
    //        {
    //            DataRow rows = data.Rows[0];
    //            //0.ESTADO, 1.RUT, 2.DV, 3.NOMBRE,4.APELLIDO,5.NOMBRE_EMPRESA, 6.NRO_ORDEN, 7.DESCRIPCION AS HABITACION,
    //            //8.FECHA_INGRESO, 9.FECHA_SALIDA,10.DESCRIPCION AS SERVICIO,11.NOMBRE_MINUTA,12.NOMBRE_PLATO 
    //            txDatosHue.Visible = true;
    //            txDatosHue.Text = "\r\n";
    //            txDatosHue.Text += "Nro OC : " + rows[6].ToString() + "\r\n";
    //            txDatosHue.Text += "Empresa : " + rows[5].ToString() + "\r\n";
    //            txDatosHue.Text += "\r\n \r\n";
    //            txDatosHue.Text += "RUT : " + rows[1].ToString() + "-" + rows[2].ToString() + "\r\n";
    //            txDatosHue.Text += "Nombre : " + rows[3].ToString() + " " + rows[4].ToString() + "\r\n \r\n";
    //            txDatosHue.Text += "\r\n \r\n";
    //            txDatosHue.Text += "Habitacion : " + rows[7].ToString() + "\r\n";
    //            txDatosHue.Text += "Comedor : " + rows[10].ToString() + "\r\n";
    //            txDatosHue.Text += "\r\n \r\n";
    //            txDatosHue.Text += "Fecha Ingreso : " + rows[8].ToString() + "\r\n";
    //            txDatosHue.Text += "Fecha Salida : " + rows[9].ToString() + "\r\n \r\n";
    //            txDatosHue.Text += "\r\n \r\n";
    //            txDatosHue.Text += "Estado Huesped : " + rows[0].ToString();
    //            txOrdenCom.ReadOnly = true;
    //            lbMsg.Text = "Seleccione Ingreso o Salida del Huesped";
    //        }

        
    }
    }
}
