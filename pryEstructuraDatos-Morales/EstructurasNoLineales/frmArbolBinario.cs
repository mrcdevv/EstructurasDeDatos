using System;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasNoLineales
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        // CLASE ARBOL
        clsArbolBinario arbol = new clsArbolBinario();
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nodo = new clsNodo();

            if (txtValor.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                nodo.Valor = Convert.ToInt32(txtValor.Text);
                nodo.Nombre = txtNombre.Text;
                nodo.Tramite = txtTramite.Text;

                arbol.Agregar(nodo);

                if (arbol.Raiz != null)
                {
                    arbol.Equilibrar();
                }

                recorrerSegunOPT(); // Recorrer segun que orden este seleccionado

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
                arbol.Equilibrar(Convert.ToInt32(cbValor.Text));
                
                recorrerSegunOPT();

                if (arbol.Raiz == null)
                {

                    dgvDatos.Rows.Clear();
                    cbValor.Items.Clear();
                    lstDatos.Items.Clear();
                    tv.Nodes.Clear();
                }
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEliminar.Enabled = false;
            }
        }

        private void recorrerSegunOPT()
        {
            if(arbol.Raiz != null)
            {
                arbol.RecorrerInOrdenAsc(tv); // Al treeview siempre se lo recorre de la misma manera
                if (optAscOrd.Checked == true)
                {
                    arbol.RecorrerInOrdenAsc(lstDatos);
                    arbol.RecorrerInOrdenAsc(cbValor);
                    arbol.RecorrerInOrdenAsc(dgvDatos);
                }
                if (optDescOrd.Checked == true)
                {
                    arbol.RecorrerInOrdenDes(lstDatos);
                    arbol.RecorrerInOrdenDes(cbValor);
                    arbol.RecorrerInOrdenDes(dgvDatos);
                }
                if (optPost.Checked == true)
                {
                    arbol.RecorrerPostOrden(lstDatos);
                    arbol.RecorrerPostOrden(cbValor);
                    arbol.RecorrerPostOrden(dgvDatos);
                }
                else
                {
                    arbol.RecorrerPreOrden(lstDatos);
                    arbol.RecorrerPreOrden(cbValor);
                    arbol.RecorrerPreOrden(dgvDatos);
                }

            }
        }

        private void optAscOrd_CheckedChanged(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                arbol.RecorrerInOrdenAsc(tv);
                arbol.RecorrerInOrdenAsc(lstDatos);
                arbol.RecorrerInOrdenAsc(cbValor);
                arbol.RecorrerInOrdenAsc(dgvDatos);
            }
            
        }

        private void optDescOrd_CheckedChanged(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                arbol.RecorrerInOrdenDes(lstDatos);
                arbol.RecorrerInOrdenDes(cbValor);
                arbol.RecorrerInOrdenDes(dgvDatos);
            }
        }

        private void optPre_CheckedChanged(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                arbol.RecorrerPreOrden(lstDatos);
                arbol.RecorrerPreOrden(cbValor);
                arbol.RecorrerPreOrden(dgvDatos);
            }
        }

        private void optPost_CheckedChanged(object sender, EventArgs e)
        {
            if (arbol.Raiz != null)
            {
                arbol.RecorrerPostOrden(lstDatos);
                arbol.RecorrerPostOrden(cbValor);
                arbol.RecorrerPostOrden(dgvDatos);
            }
        }
    }
}
