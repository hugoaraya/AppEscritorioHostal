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
namespace WFHostalAPPEscritorio
{
    public partial class MantenedorHuespedes : Form
    {
        public MantenedorHuespedes()
        {
            InitializeComponent();
            llenarGrilla();
        }

        public void llenarGrilla()
        {
            ManHuesped man = new ManHuesped();
            dgvHuesped.DataSource = man.TodosHuepedes();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txRut.Text))
            {
                lbMsg.Text = ("Debe completar la informacion RUT");
                txRut.Focus();
                return;
            }
            try
            {
                ManHuesped man = new ManHuesped();
                DataTable dt = man.UnHueped(txRut.Text.Trim());
                dgvHuesped.DataSource = dt;
                if (dt == null)
                {
                    lbMsg.Text = "Huesped No existe";
                    dgvHuesped.DataSource = "";
                    txRut.Enabled = true;
                    txRut.Focus();

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
                        txRut.Text = row[0].ToString();
                        txNombre.Text = row[2].ToString();
                        txApellido.Text = row[3].ToString();
                        txTelefono.Text = row[4].ToString();
                        txCorreo.Text = row[5].ToString();
                        txCargo.Text = row[6].ToString();
                        txRutEmp.Text = row[7].ToString();
                        lbMsg.Text = "Heusped Encontrado";
                        txRut.Enabled = false;

                    }

                }

            }
            catch (Exception ex)
            {
                lbMsg.Text = "ERROR: " + ex;

            }

        }

        private void MantenedorHuespedes_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarDatos()
        {
            txRut.Text = "";
            txNombre.Text = "";
            txApellido.Text = "";
            txTelefono.Text = "";
            txCorreo.Text = "";
            txCargo.Text = "";
            txRutEmp.Text = "";
            llenarGrilla();
            txRut.Focus();
            txRut.Enabled = true;
            lbMsg.Text = "";

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txRut.Text))
            {
                lbMsg.Text = ("Debe completar la informacion RUT");
                txRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Debe completar la informacion NOMBRE");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txApellido.Text))
            {
                lbMsg.Text = ("Debe completar la informacion DIRECCION");
                txApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txTelefono.Text))
            {
                lbMsg.Text = ("Debe completar la informacion TELEFONO");
                txTelefono.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txCorreo.Text))
            {
                lbMsg.Text = ("Debe completar la informacion CORREO");
                txCorreo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txCargo.Text))
            {
                lbMsg.Text = ("Debe completar la informacion CARGO");
                txCargo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txRutEmp.Text))
            {
                lbMsg.Text = ("Debe completar la informacion RUT EMPRESA");
                txRutEmp.Focus();
                return;
            }

            ManHuesped man = new ManHuesped();
            MetodosAPP APP = new MetodosAPP();

            if (man.validarRutHuesped(txRut.Text))
            {
                if (man.ObtenerIDEmpresa(txRutEmp.Text) == 0)
                {
                    txRutEmp.Focus();
                    lbMsg.Text = "Empresa no Existe";
                    return;
                }
                else
                {
                    HUESPED hues = new HUESPED();
                    hues.IDHUESPED = 1;
                    hues.RUT = int.Parse(txRut.Text);
                    hues.DV = APP.GenerarDV(txRut.Text);
                    hues.NOMBRE = txNombre.Text;
                    hues.APELLIDO = txApellido.Text;
                    hues.TELEFONO = int.Parse(txTelefono.Text);
                    hues.CORREO = txCorreo.Text;
                    hues.CARGO = txCargo.Text;
                    hues.EMPRESA_ID = man.ObtenerIDEmpresa(txRutEmp.Text);

                    AddHuesped(hues);
                    llenarGrilla();
                    LimpiarDatos();
                    lbMsg.Text = "Huesped Creado";
                }
            }
            else
            {
                lbMsg.Text = "Rut Cliente ya Existe";
                return;
            }
            

            }
        public void AddHuesped(HUESPED hue)
        {
            using (EntitiesHostal con = new EntitiesHostal())
            {
                con.HUESPED.Add(hue);
                con.SaveChanges();
            }
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FALTA PROGRAMAR:::");
        }
    }
}

