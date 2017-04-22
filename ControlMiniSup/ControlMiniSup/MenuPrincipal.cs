using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlMiniSup
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCliente cliente = new rCliente();
            cliente.ShowDialog();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulo articulo = new rArticulo();
            articulo.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedor proveedor = new rProveedor();
            proveedor.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuario usuario = new rUsuario();
            usuario.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoria categoria = new rCategoria();
            categoria.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCliente cliente = new cCliente();
            cliente.ShowDialog();
        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cArticulo articulo = new cArticulo();
            articulo.ShowDialog();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProveedor proveedor = new cProveedor();
            proveedor.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuario usuario = new cUsuario();
            usuario.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cCategoria categoria = new cCategoria();
            categoria.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.ShowDialog();
        }
    }
}
