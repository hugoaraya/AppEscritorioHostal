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
    public partial class FormularioAdmin : Form
    {
        public FormularioAdmin()
        {
            InitializeComponent();
        }

        private void mantenedorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados formulario = new MantenedorEmpleados();
            formulario.ShowDialog();
        }
    }
}
