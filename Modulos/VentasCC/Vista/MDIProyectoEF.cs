using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace CapaVistaMVentasCC
{
    public partial class MDIProyectoEF : Form
    {
        public MDIProyectoEF()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoCliente form3 = new frmMantenimientoCliente();
            form3.MdiParent = this;
            form3.Show();
        }

        private void morasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void fraccionamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoInventario form3 = new frmMantenimientoInventario();
            form3.MdiParent = this;
            form3.Show();
        }

        private void tipoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoInventario form3 = new frmMantenimientoTipoInventario();
            form3.MdiParent = this;
            form3.Show();
        }

        private void MDIVentas_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { this.Close(); }
        }

        private void mantienimientoTipoComisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoComision form3 = new frmMantenimientoTipoComision();
            form3.MdiParent = this;
            form3.Show();
        }

        private void mantenimientoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoBodega form3 = new frmMantenimientoBodega();
            form3.MdiParent = this;
            form3.Show();
        }

        private void tipoBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoBodega form3 = new frmMantenimientoTipoBodega();
            form3.MdiParent = this;
            form3.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoMarca form3 = new frmMantenimientoMarca();
            form3.MdiParent = this;
            form3.Show();
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoLinea form3 = new frmMantenimientoLinea();
            form3.MdiParent = this;
            form3.Show();
        }

        private void matenimientoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto form3 = new frmMantenimientoProducto();
            form3.MdiParent = this;
            form3.Show();
        }
    }
}
