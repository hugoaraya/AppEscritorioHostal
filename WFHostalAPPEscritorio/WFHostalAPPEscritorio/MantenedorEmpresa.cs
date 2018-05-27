using System;
using System.Data;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;
using DAO;
using Oracle.DataAccess.Client;
using System.Linq;
using System.Collections.Generic;
using System.Data.OracleClient;

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
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRut.Text) == false)
            {
                lbMsg.Text = ("Ingrese Rut Valido");
                txRut.Focus();
                return;
            }
            else
            {
                try
                {
                    ManEmpresa man = new ManEmpresa();
                    DataTable dt = man.EmpresaXRut(APP.ObtenerRut(txRut.Text));
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

                            txRut.Text = row[1].ToString()+"-"+ row[2].ToString();
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
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRut.Text) == false || txRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Valido");
                txRut.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txNombre.Text) || txNombre.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese la información NOMBRE +4");
                txNombre.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txDireccion.Text))
            {
                lbMsg.Text = ("Ingrese la información DIRECCIÓN");
                txDireccion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txTelefono.Text))
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
            string pDIRECC = txDireccion.Text;
            int pTELEFONO = int.Parse(txTelefono.Text);
            string pCORREO = txCorreo.Text;

                using (EntitiesHostal con = new EntitiesHostal())
                {
                    var test = con.EMPRESA.Where(x => x.RUT == pRUT).FirstOrDefault();
                    Console.Write(test);
                    Console.Write(test.NOMBRE.ToString());
                    test.NOMBRE = pNOMBRE;
                    test.DIRECCION = pDIRECC;
                    test.TELEFONO = pTELEFONO;
                    test.CORREO = pCORREO;
                    if (con.SaveChanges() > 0)
                    {
                        lbMsg.Text = "Registro Actualizado";
                        
                    }
                    else
                    {
                        Console.Write("PREOBLEMAS AL ACTUALIZAR DATOS_:" + e);
                        lbMsg.Text = "Problemas al actualizar. Revise los datos";
                        
                    }
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

    }
        
    }
