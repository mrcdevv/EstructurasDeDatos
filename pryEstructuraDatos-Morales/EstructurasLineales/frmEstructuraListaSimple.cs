using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    public partial class frmEstructuraListaSimple : Form
    {
        public frmEstructuraListaSimple()
        {
            InitializeComponent();
        }

        private void frmEstructuraListaSimple_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        // CLASE LISTA SIMPLE
        clsListaSimple lista = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtValor.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                // Cargo datos al nodo
                nodo.Valor = Convert.ToInt32(txtValor.Text);
                nodo.Nombre = txtNombre.Text;
                nodo.Tramite = txtTramite.Text;

                lista.Agregar(nodo);
                lista.Recorrer(dgvDatos);
                lista.Recorrer(lstDatos);
                lista.Recorrer(cbValor);

                txtValor.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";

                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbValor.Items.Count != 0)
            {
                int codigo = Convert.ToInt32(cbValor.Text);

                lista.Eliminar(codigo);
                lista.Recorrer(dgvDatos);
                lista.Recorrer(lstDatos);
                lista.Recorrer(cbValor);
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEliminar.Enabled = false;
            }
        }
    }
}
