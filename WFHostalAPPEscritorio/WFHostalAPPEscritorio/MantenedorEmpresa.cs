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

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorEmpresa : Form
    {
        public MantenedorEmpresa()
        {
            InitializeComponent();
            CargarDGVEmpresa();
        }

        private void CargarDGVEmpresa()
        {
            this.dgvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.MultiSelect = false;
            this.dgvEmpresa.ReadOnly = true;
            ManEmpresa man = new ManEmpresa();
            dgvEmpresa.DataSource = man.todasEmpresas();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txRut.Text = "";
            txNombre.Text = "";
            txDireccion.Text = "";
            txTelefono.Text = "";
            txCorreo.Text = "";
            txRut.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txRut.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar RUT sin DV";
                txRut.Focus();
            }
            else
            {
                try
                {
                    ManEmpresa man = new ManEmpresa();
                    DataTable dt = man.EmpresaXRut(txRut.Text.Trim());
                    dgvEmpresa.DataSource = dt;
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

                            txRut.Text = row[1].ToString();
                            txNombre.Text = row[2].ToString();
                            txDireccion.Text = row[3].ToString();
                            txTelefono.Text = row[4].ToString();
                            txCorreo.Text = row[6].ToString();
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
            CargarDGVEmpresa();
        }

        //Validar que campos  sean numericos
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



        private void dgvEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("FALTA PROGRAMAR ESTO");
            //rellenar con seleccion de fila. ?????
            //DataTable dato = 

            //if (dato.Rows.Count == 0)
            //{
            //    return;
            //}
            //else
            //{
            //    DataRow row = dt.Rows[0];

            //    txRut.Text = row[1].ToString();
            //    txNombre.Text = row[2].ToString();
            //    txDireccion.Text = row[3].ToString();
            //    txTelefono.Text = row[4].ToString();
            //    txCorreo.Text = row[6].ToString();
            //    txRut.Enabled = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txRut.Text.Trim() == "")
            {
                lbMsg.Text = "Asegúrese de ingresar RUT sin DV";
                txRut.Focus();
            }
            else
            {
                try
                {
                    ManEmpresa man = new ManEmpresa();
                    DataTable dt = man.EmpresaXRut(txRut.Text.Trim());
                    if (dt == null)
                    {
                        MessageBox.Show("FALTA PROGRAMAR ESTO");
                    }
                    else
                    {
                        lbMsg.Text = "RUT ya existe";
                    }

                }
                catch (Exception ex)
                {
                    lbMsg.Text = "ERROR: " + ex;

                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FALTA PROGRAMAR ESTO");
        }
    }


}