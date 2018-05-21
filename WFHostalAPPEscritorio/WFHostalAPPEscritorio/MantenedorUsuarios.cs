using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAO;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorUsuarios : Form
    {

        public MantenedorUsuarios()
        {
            InitializeComponent();
            rellenarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txContra.Text = "";
            txNombre.Text = "";
            txContra.Enabled = false;
            txNombre.Enabled = true;
        }


        private void rellenarGrilla()
        {
            ManUsuario man = new ManUsuario();
            dgvUsuario.DataSource = man.TodosUsuarios();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            rellenarGrilla();
        }

        private void MantenedorUsuarios_Load(object sender, EventArgs e)
        {

            txContra.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(txNombre.Text))
        {
            lbMsg.Text = ("Debe completar la informacion RUT/nombre");
            txNombre.Focus();
            return;
        }

            try
            {
                ManUsuario man = new ManUsuario();
                DataTable dt = man.UnUsuario(txNombre.Text.Trim());
                dgvUsuario.DataSource = dt;
                if (dt == null)
                {
                    lbMsg.Text = "Usuario No existe";
                    dgvUsuario.DataSource = "";
                    txNombre.Enabled = true;
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
                        txNombre.Text = row[1].ToString();
                        txContra.Text = row[2].ToString();
                        txNombre.Enabled = false;
                        lbMsg.Text = "Usuario Encontrado";
                        txContra.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                lbMsg.Text = "ERROR: " + ex;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PENDIENTE DE PROGRAMAR");
        }
    }
}
