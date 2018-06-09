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
        }

        public void llenarGrilla()
        {
            ManHuesped man = new ManHuesped();
            dgvHuesped.DataSource = man.TodosHuepedes();
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
                MetodosAPP APP = new MetodosAPP();
                DataTable dt = man.UnHueped(APP.ObtenerRut(txRut.Text.Trim()));
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
                        txRut.Text = row[0].ToString() + "-" + row[1].ToString();
                        txNombre.Text = row[2].ToString();
                        txApellido.Text = row[3].ToString();
                        txTelefono.Text = row[4].ToString();
                        txCorreo.Text = row[5].ToString();
                        txRutEmp.Text = row[7].ToString() + "-" + row[8].ToString();
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

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void MantenedorHuespedes_Load(object sender, EventArgs e)
        {
            this.dgvHuesped.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvHuesped.MultiSelect = false;
            this.dgvHuesped.ReadOnly = true;
            llenarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        public void LimpiarDatos()
        {
            txRut.Text = "";
            txNombre.Text = "";
            txApellido.Text = "";
            txTelefono.Text = "";
            txCorreo.Text = "";            
            txRutEmp.Text = "";
            llenarGrilla();
            txRut.Focus();
            txRut.Enabled = true;
            lbMsg.Text = "";
            txRut.ReadOnly = false;
            txRutEmp.ReadOnly = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHuesped_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;
            //0.RUT,1.DV,2.NOMBRE,3.APELLIDO,4.TELEFONO,5.CORREO,6.CARGO,7.RUT AS RUT_EMPRESA
            txRut.Text = row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString();
            txNombre.Text = row.Cells[2].Value.ToString();
            txApellido.Text = row.Cells[3].Value.ToString();
            txTelefono.Text = row.Cells[4].Value.ToString();
            txCorreo.Text = row.Cells[5].Value.ToString();
            txRutEmp.Text = row.Cells[7].Value.ToString() + "-" + row.Cells[8].Value.ToString();
            txRut.ReadOnly = true;
            txRutEmp.ReadOnly = true;
        }

        private void btnXRut_Click(object sender, EventArgs e)
        {
            ManHuesped man = new ManHuesped();
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRutEmp.Text) == false || string.IsNullOrEmpty(txRutEmp.Text))
            {
                lbMsg.Text = ("Ingrese Rut Empresa valido");
                txRutEmp.ReadOnly = false;
                txRutEmp.Focus();
                return;
            }
            if (man.ObtenerIDEmpresa(APP.ObtenerRut(txRutEmp.Text)) == 0)
            {
                dgvHuesped.DataSource = "";
                txRutEmp.ReadOnly = false;
                lbMsg.Text = ("Empresa No Encontrada");
            }
            else {
                dgvHuesped.DataSource = man.GetHuespedesXRut(APP.ObtenerRut(txRutEmp.Text));
                txRutEmp.ReadOnly = true;
                lbMsg.Text = ("Empresa Encontrada");
            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRut.Text) == false || txRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Valido");
                txRut.ReadOnly = false;
                txRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Ingrese la información NOMBRE");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txApellido.Text))
            {
                lbMsg.Text = ("Ingrese la información APELLIDO");
                txApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txTelefono.Text) || txTelefono.Text.Length >= 12)
            {
                lbMsg.Text = ("Ingrese la información TELÉFONO");
                txTelefono.Focus();
                return;
            }
            if (APP.ValidacionEmail(txCorreo.Text) == false)
            {
                lbMsg.Text = ("Ingrese la información CORREO valido");
                txCorreo.Focus();
                return;
            }

            int pRUT = int.Parse(APP.ObtenerRut(txRut.Text));
            string pNOMBRE = txNombre.Text;
            string pAPELLIDO = txApellido.Text;
            Int64 pTELEFONO = Int64.Parse(txTelefono.Text);
            string pCORREO = txCorreo.Text;

            using (EntitiesHostal con = new EntitiesHostal())
            {
                var test = con.HUESPED.Where(x => x.RUT == pRUT).FirstOrDefault();
                Console.Write(test);
                Console.Write(test.NOMBRE.ToString());
                test.NOMBRE = pNOMBRE;
                test.APELLIDO = pAPELLIDO;
                test.TELEFONO = pTELEFONO;
                test.CORREO = pCORREO;
                if (con.SaveChanges() > 0)
                {
                    LimpiarDatos();
                    lbMsg.Text = "Registro Actualizado";
                }
                else
                {
                    Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";

                }
            }



            MessageBox.Show("Pendiente de Desarrollo");
        }
    }
}
