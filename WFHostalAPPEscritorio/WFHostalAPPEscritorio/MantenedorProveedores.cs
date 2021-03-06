﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Oracle.DataAccess.Client;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio
{
    public partial class MantenedorProveedores : Form
    {
        public MantenedorProveedores()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txRut.Text = "";
            txNombre.Text = "";
            txDireccion.Text = "";
            txRut.Enabled = true;
            lbMsg.Text = "";
        }

        public void LlenarGrilla()
        {
            ManProveedor man = new ManProveedor();
            dgvProveedor.DataSource = man.todosProveedor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            if (APP.validarRut(txRut.Text) == false || txRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Valido");
                txRut.Focus();
                return;
            }
         
                try
                {
                    ManProveedor man = new ManProveedor();
                    DataTable dt = man.ProveedorXRut(APP.ObtenerRut(txRut.Text));
                    dgvProveedor.DataSource = dt;
                    if (dt == null)
                    {
                        lbMsg.Text = "RUT No existe";
                        dgvProveedor.DataSource = "";
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

                            txRut.Text = row[0].ToString()+ "-" + row[1].ToString();
                            txNombre.Text = row[2].ToString();
                            txDireccion.Text = row[3].ToString();
                            cbxRubro.Text = row[4].ToString();
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

        private void btnTodos_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void MantenedorProveedores_Load(object sender, EventArgs e)
        {
            this.dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.MultiSelect = false;
            this.dgvProveedor.ReadOnly = true;
            LlenarGrilla();

            ManProveedor man = new ManProveedor();
            DataTable dtRubros = man.GetRubros();
            if (dtRubros == null)
            {
                lbMsg.Text = "problema al cargar rubro";
            }
            else
            {
                for (int i = 0; i < dtRubros.Rows.Count; i++)
                {
                    DataRow row = dtRubros.Rows[i];
                    cbxRubro.Items.Add(row[1]);
                }
            }
            cbxRubro.Items.Insert(0, "-Seleccione Rubro-");
            cbxRubro.SelectedIndex = 0;



        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            var row = (sender as DataGridView).CurrentRow;
            txRut.Text = row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString();
            txNombre.Text = row.Cells[2].Value.ToString();
            txDireccion.Text = row.Cells[3].Value.ToString();
            cbxRubro.Text = row.Cells[4].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MetodosAPP APP = new MetodosAPP();
            ManProveedor man = new ManProveedor();
            string pRubro = "";
            if (APP.validarRut(txRut.Text) == false || txRut.Text.Length <= 3)
            {
                lbMsg.Text = ("Ingrese Rut Válido");
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
            if (cbxRubro.SelectedIndex == 0)
            {
                lbMsg.Text = ("Seleccione un Rubro");
                cbxRubro.Focus();
                return;
            }
            else
            {
                pRubro = cbxRubro.SelectedItem.ToString();
            }

            int pRUT = int.Parse(APP.ObtenerRut(txRut.Text));
            string pNOMBRE = txNombre.Text;
            string pDIRECC = txDireccion.Text;
            

            using (EntitiesHostal con = new EntitiesHostal())
            {
                var test = con.PROVEEDOR.Where(x => x.RUT == pRUT).FirstOrDefault();
                Console.Write(test);
                Console.Write(test.NOMBRE.ToString());
                test.NOMBRE = pNOMBRE;
                test.DIRECCION = pDIRECC;
                test.RUBRO_ID = man.GetIDRubro(pRubro); 
                if (con.SaveChanges() > 0)
                {
                    lbMsg.Text = "Registro Actualizado";
                    dgvProveedor.DataSource = "";
                }
                else
                {
                    Console.Write("PROBLEMAS AL ACTUALIZAR DATOS_:" + e);
                    lbMsg.Text = "Problemas al actualizar. Revise los datos";

                }
            }






        }
    }
}
