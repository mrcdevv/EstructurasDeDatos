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
    public partial class frmEstructuraPila : Form
    {
        public frmEstructuraPila()
        {
            InitializeComponent();
        }

        private void frmEstructuraPila_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        // CLASE PILA 
        clsPila pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtValor.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                // Cargo datos al nodo
                nodo.Valor = Convert.ToInt32(txtValor.Text);
                nodo.Nombre = txtNombre.Text;
                nodo.Tramite = txtTramite.Text;

                pila.Agregar(nodo);
                pila.Recorrer(lstDatos);
                pila.Recorrer(dgvDatos);

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
            if (pila.primero != null)
            {
                txtValorElim.Text = pila.primero.Valor.ToString();
                txtNombreElim.Text = pila.primero.Nombre;
                txtTramiteElim.Text = pila.primero.Tramite;

                pila.Eliminar();
                pila.Recorrer(lstDatos);
                pila.Recorrer(dgvDatos);
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtValorElim.Text = "";
                txtNombreElim.Text = "";
                txtTramiteElim.Text = "";

            }
        }
    }
}
