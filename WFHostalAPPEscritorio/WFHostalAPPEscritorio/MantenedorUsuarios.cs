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
            lbMsg.Text = "";
        }


        private void rellenarGrilla()
        {
            ManUsuario man = new ManUsuario();
            dgvUsuario.DataSource = man.GetUsuariosActivos();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantenedorUsuarios_Load(object sender, EventArgs e)
        {
            txUpdate.Visible = false;
            txContra.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Debe completar la informacion Usuario/RUT");
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
                        txNombre.Text = row[0].ToString();
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
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Ingrese la información Usuario/Rut sin DV");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txContra.Text))
            {
                lbMsg.Text = ("Ingrese la información Nueva CONTRASEÑA");
                txContra.Focus();
                return;
            }

            string pNOMBRE = txNombre.Text;
            string pCONTRA = txContra.Text;

            using (EntitiesHostal con = new EntitiesHostal())
            {
                var test = con.USUARIO.Where(x => x.NOMBRE_USUARIO == pNOMBRE).FirstOrDefault();
                test.NOMBRE_USUARIO = pNOMBRE;
                test.CONTRASENIA = pCONTRA;
                if (con.SaveChanges() > 0)
                {
                    lbMsg.Text = "Registro Actualizado";
                    dgvUsuario.DataSource = "";
                    txContra.Text = "";
                    txNombre.Text = "";
                    txContra.Enabled = false;
                    txNombre.Enabled = true;
                    txUpdate.Visible = true;
                    txUpdate.Text = "Ultimo Cambio: Usuario: " + pNOMBRE + " Nueva contraseña: " + pCONTRA;
                }
                else
                {
                    Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";

                }
            }

        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;
            txNombre.Text = row.Cells[0].Value.ToString();
            txNombre.Enabled = false;
            txContra.Enabled = true;
        }

        private void btnEliminados_Click(object sender, EventArgs e)
        {
            ManUsuario man = new ManUsuario();
            dgvUsuario.DataSource = man.GetUsuariosEliminados();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            ManUsuario man = new ManUsuario();
            dgvUsuario.DataSource = man.GetUsuariosActivos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text))
            {
                lbMsg.Text = ("Ingrese la información Usuario/Rut sin DV");
                txNombre.Focus();
                return;
            }
            string pNOMBRE = txNombre.Text;
            DialogResult result = MessageBox.Show("¿Esta Seguro de Eliminar Usuario?", "Confirmacion de Eliminación", MessageBoxButtons.YesNo);
            Console.Write(result);
            if (result == DialogResult.Yes)
            {
                using (EntitiesHostal con = new EntitiesHostal())
                {
                    var test = con.USUARIO.Where(x => x.NOMBRE_USUARIO == pNOMBRE).FirstOrDefault();
                    test.NOMBRE_USUARIO = pNOMBRE;
                    test.TIPO_USUARIO_ID = 5;

                    if (con.SaveChanges() > 0)
                    {
                        lbMsg.Text = "Registro Eliminado";
                        dgvUsuario.DataSource = "";
                        txContra.Text = "";
                        txNombre.Text = "";
                        txContra.Enabled = false;
                        txNombre.Enabled = true;
                        txUpdate.Visible = true;
                        txUpdate.Text = "Ultimo Cambio: Usuario: " + pNOMBRE + " eliminado";
                    }
                    else
                    {
                        Console.Write("PREOBLEMAS AL ELIMINAR DATOS_:" + e);
                        lbMsg.Text = "Problemas al eliminar. Revise los datos";
                    }
                }
            }
            else
            {
                lbMsg.Text = "Problemas al eliminar Usuario. Revise los datos";
                return;
            }
        }
    }
}

