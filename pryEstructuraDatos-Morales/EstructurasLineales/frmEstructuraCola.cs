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
    public partial class frmEstructuraCola : Form
    {
        public frmEstructuraCola()
        {
            InitializeComponent();
        }

        private void frmEstructuraCola_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        // CLASE COLA
        clsCola cola = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtValor.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {

                // Cargo datos al nodo
                nodo.Valor = Convert.ToInt32(txtValor.Text);
                nodo.Nombre = txtNombre.Text;
                nodo.Tramite = txtTramite.Text;

                cola.Agregar(nodo);
                cola.Recorrer(lstDatos);
                cola.Recorrer(dgvDatos);

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
            if (cola.primero != null)
            {
                txtValorElim.Text = cola.primero.Valor.ToString();
                txtNombreElim.Text = cola.primero.Nombre;
                txtTramiteElim.Text = cola.primero.Tramite;


                cola.Eliminar();
                cola.Recorrer(lstDatos);
                cola.Recorrer(dgvDatos);
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
