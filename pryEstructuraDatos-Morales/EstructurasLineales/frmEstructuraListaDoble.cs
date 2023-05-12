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
    public partial class frmEstructuraListaDoble : Form
    {
        public frmEstructuraListaDoble()
        {
            InitializeComponent();
        }

        private void frmEstructuraListaDoble_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        // CLASE LISTA DOBLE
        clsListaDoble lista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtValor.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                // Cargo datos al nodo
                nodo.Valor = Convert.ToInt32(txtValor.Text);
                nodo.Nombre = txtNombre.Text;
                nodo.Tramite = txtTramite.Text;

                if (optAsc.Checked == true)
                {
                    lista.Agregar(nodo);
                    lista.RecorrerAsc(dgvDatos);
                    lista.RecorrerAsc(lstDatos);
                    lista.RecorrerAsc(cbValor);
                }
                else
                {
                    lista.Agregar(nodo);
                    lista.RecorrerDesc(dgvDatos);
                    lista.RecorrerDesc(lstDatos);
                    lista.RecorrerDesc(cbValor);
                }

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


                if (optAsc.Checked == true)
                {
                    lista.Eliminar(codigo);
                    lista.RecorrerAsc(dgvDatos);
                    lista.RecorrerAsc(lstDatos);
                    lista.RecorrerAsc(cbValor);
                } 
                else
                {
                    lista.Eliminar(codigo);
                    lista.RecorrerDesc(dgvDatos);
                    lista.RecorrerDesc(lstDatos);
                    lista.RecorrerDesc(cbValor);
                }
                
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEliminar.Enabled = false;
            }
        }

        private void optAsc_CheckedChanged(object sender, EventArgs e)
        {
            lista.RecorrerAsc(dgvDatos);
            lista.RecorrerAsc(lstDatos);
            lista.RecorrerAsc(cbValor);
        }

        private void optDesc_CheckedChanged(object sender, EventArgs e)
        {
            lista.RecorrerDesc(dgvDatos);
            lista.RecorrerDesc(lstDatos);
            lista.RecorrerDesc(cbValor);
        }
    }
}
