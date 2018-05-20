using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHostalAPPEscritorio
{
    public partial class RegistrarEmpresa : Form
    {
        public RegistrarEmpresa()
        {
            InitializeComponent();
            //IDEMPRESA
            //RUT
            //DV
            //NOMBRE
            //DIRECCION
            //TELEFONO
            //USUARIO_ID
            //CORREO
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
