using pryEstructuraDatos_Morales.EstructurasLineales;
using pryEstructuraDatos_Morales.EstructurasNoLineales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosPersonales frmDatosPersonales = new frmDatosPersonales();
            frmDatosPersonales.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraPila frmEstructuraPila = new frmEstructuraPila();
            frmEstructuraPila.ShowDialog();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraCola frmEstructuraCola = new frmEstructuraCola();
            frmEstructuraCola.ShowDialog();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraListaSimple frmEstructuraListaSimple = new frmEstructuraListaSimple();
            frmEstructuraListaSimple.ShowDialog();
        }

        private void listaEnlazadaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraListaDoble frmEstructuraListaDoble = new frmEstructuraListaDoble();
            frmEstructuraListaDoble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbolBinario = new frmArbolBinario();
            frmArbolBinario.ShowDialog();
        }
    }
}
