﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFHostalAPPEscritorio.Clases;

namespace WFHostalAPPEscritorio
{
    public partial class FormularioAdmin : Form
    {
        public FormularioAdmin()
        {
            InitializeComponent();

            //Datos de Bienvenida            
            LbBienvenida.Text = ("Bienvenido...  Usuario Activo: " + Global.usuarioKEY[1] + ",   Tipo de Usuario: " + Global.usuarioKEY[4]);
        }

        private void mantenedorEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorEmpleados formulario = new MantenedorEmpleados();
            formulario.ShowDialog();
        }

        private void mantenedorEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorEmpresa formulario = new MantenedorEmpresa();
            formulario.ShowDialog();
        }


        private void mantenedorOrdenDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorOrdenDeServicios formulario = new MantenedorOrdenDeServicios();
            formulario.ShowDialog();
        }

        private void mantenedorOrdenDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorOrdenDePedido formulario = new MantenedorOrdenDePedido();
            formulario.ShowDialog();
        }

        private void mantenedorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProducto formulario = new MantenedorProducto();
            formulario.ShowDialog();
        }

        private void mantenedorProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorProveedores formulario = new MantenedorProveedores();
            formulario.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login formulario = new Login();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void registrarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEmpresa formulario = new RegistrarEmpresa();
            formulario.ShowDialog();
        }

     

  

        private void mantenedorComedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorHuespedes formulario = new MantenedorHuespedes();
            formulario.ShowDialog();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProveedor formulario = new RegistrarProveedor();
            formulario.ShowDialog();
        }

        private void checkINCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckHuesped formulario = new CheckHuesped();
            formulario.ShowDialog();
        }

        private void mantenedorFacturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MantenedorFacturas formulario = new MantenedorFacturas();
            formulario.ShowDialog();
        }

        private void registrarEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ingresar_Empleado formulario = new Ingresar_Empleado();
            formulario.ShowDialog();
        }

        private void mantenedorUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MantenedorUsuarios formulario = new MantenedorUsuarios();
            formulario.ShowDialog();
        }

        private void ingresarOrdenDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoOrdenPedido formulario = new IngresoOrdenPedido();
            formulario.ShowDialog();
        }

        private void recepciónDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionOrdenPedido formulario = new RecepcionOrdenPedido();
            formulario.ShowDialog();
        }

        private void generarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarFacturas formulario = new GenerarFacturas();
            formulario.ShowDialog();
        }
    }
}

