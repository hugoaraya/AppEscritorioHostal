using System;
using System.Data;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;
using DAO;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Collections.Generic;


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
                lbMsg.Text = "Asegúrese de ingresar RUT";
                txRut.Focus();
            }
            else
            {
                try
                {
                    ManEmpresa man = new ManEmpresa();
                    Console.Write(man.ToString());
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

        private void MantenedorEmpresa_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
            txtDv.Enabled = false;
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
            Conectar conexion = new Conectar();
            conexion.Abrir();
            int pRUT = int.Parse(txRut.Text);
            string pNOMBRE = txNombre.Text;

            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd;
            OracleParameter parm;

            // Create the SelectCommand.
            
            cmd = new OracleCommand("SELECT * FROM EMPRESA " +
                                 "WHERE RUT = pRUT", conexion.con);

            cmd.Parameters.Add("pRUT", OracleDbType.Int32, 10);


            da.SelectCommand = cmd;


            //string pDV = txtDv.Text;
            
            //string DIRECCION = txDireccion.Text;
            //int TELEFONO
            



            // Create the UpdateCommand.
            //IDEMPRESA,RUT,DV,NOMBRE,DIRECCION,TELEFONO,USUARIO_ID,CORREO
            cmd = new OracleCommand("UPDATE EMPRESA SET NOMBRE = pNOMBRE " +
                                 "WHERE RUT = pRUT", conexion.con);

            cmd.Parameters.Add("pRUT", OracleDbType.Int32, 10, "RUT");
            cmd.Parameters.Add("pNOMBRE", OracleDbType.NVarchar2, 50, "NOMBRE");

            parm = cmd.Parameters.Add("pRUT", OracleDbType.Int32, 10, "RUT");
            parm.SourceVersion = DataRowVersion.Original;

            da.UpdateCommand = cmd;

            cmd.ExecuteNonQuery();                

            lbMsg.Text = "OK update";
            conexion.Cerrar();
        }

        private void txRut_TextChanged(object sender, EventArgs e)
        {

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

    }
        
    }
