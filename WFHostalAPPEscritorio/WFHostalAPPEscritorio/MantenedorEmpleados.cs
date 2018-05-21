using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using WFHostalAPPEscritorio.Clases;


namespace WFHostalAPPEscritorio
{
    public partial class MantenedorEmpleados : Form
    {
        Conectar conexion = new Conectar();
        public MantenedorEmpleados()
        {
            InitializeComponent();
        }
        
        #region Métodos
        private void Reiniciar()
        {
            txtRutEmp.Clear();
            txtDv.Clear();
            txtNombreEmp.Clear();
            txtApellidoEmp.Clear();

        } 
        #endregion

        private void btnIngresarEmp_Click(object sender, EventArgs e)
        {
            
            conexion.Abrir();
            try
            {
                // (IDEMPLEADO, RUT, DV, NOMBRE, APELLIDO, USUARIO_ID) 
                // (SEQ_EMPLEADO.NEXTVAL, '" + txtRutEmp.Text + "','" + txtDv.Text + "','" + txtNombreEmp.Text + "','" + txtApellidoEmp.Text + "', SEQ_USUARIO.NEXTVAL);");
                OracleCommand sql = new OracleCommand("INSERT INTO EMPLEADO VALUES ('" + txtRutEmp.Text + "','" + txtDv.Text + "','" + txtNombreEmp.Text + "','" + txtApellidoEmp.Text + "');");
                OracleDataAdapter dtaa = new OracleDataAdapter();
                dtaa.InsertCommand = sql;
                dtaa.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("¡Empleado registrado correctamente!");
            }
            catch (Exception)   
            {
                MessageBox.Show("UPS, error al ingresar Empleado :(");
            }
            conexion.Cerrar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
    }
}
