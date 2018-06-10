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
    public partial class RecepcionOrdenPedido : Form
    {
        public RecepcionOrdenPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenedorOrdenDePedido formulario = new MantenedorOrdenDePedido();
            formulario.ShowDialog();
        }
    }
}
