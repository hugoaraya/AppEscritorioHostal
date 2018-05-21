using System;
using System.Data;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;
using DAO;


namespace WFHostalAPPEscritorio
{
    public partial class MantenedorEmpresa : Form
    {
        public MantenedorEmpresa()
        {
            InitializeComponent();
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
            lbMsg.Text = "";
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
                            txNombre.Text = row[3].ToString();
                            txDireccion.Text = row[4].ToString();
                            txTelefono.Text = row[5].ToString();
                            txCorreo.Text = row[7].ToString();
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
        public void LlenarGrilla()
        {
            this.dgvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresa.MultiSelect = false;
            this.dgvEmpresa.ReadOnly = true;
            ManEmpresa man = new ManEmpresa();
            dgvEmpresa.DataSource = man.todasEmpresas();
        }



        private void btnTodas_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
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



        //private void dgvEmpresa_SelectionChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("FALTA PROGRAMAR ESTO");
        //    //rellenar con seleccion de fila. ?????
        //    //DataTable dato = 

        //    //if (dato.Rows.Count == 0)
        //    //{
        //    //    return;
        //    //}
        //    //else
        //    //{
        //    //    DataRow row = dt.Rows[0];

        //    //    txRut.Text = row[1].ToString();
        //    //    txNombre.Text = row[2].ToString();
        //    //    txDireccion.Text = row[3].ToString();
        //    //    txTelefono.Text = row[4].ToString();
        //    //    txCorreo.Text = row[6].ToString();
        //    //    txRut.Enabled = false;
        //}

    

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("PENDIENTE DE PROGRAMAR");
            //MetodosAPP APP = new MetodosAPP();

            //EMPRESA empr = new EMPRESA();
            //empr.IDEMPRESA = 1;
            //empr.RUT = int.Parse(txRut.Text);
            //empr.DV = APP.GenerarDV(txRut.Text);
            //empr.NOMBRE = txNombre.Text;
            //empr.DIRECCION = txDireccion.Text;
            //empr.TELEFONO = int.Parse(txTelefono.Text);
            //empr.USUARIO_ID = 5;                            /// COMPROBAR CON USUARIO;
            //empr.CORREO = txCorreo.Text;
            ////APP.Update(empr);                             /// COMPROBAR CON USUARIO;
            //lbMsg.Text = "aaaa";
        }

        private void MantenedorEmpresa_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
        }
    }


}