using System.IO;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasNoLineales
{
    internal class clsArbolBinario
    {
        private clsNodo raiz;
        private clsNodo[] Vector = new clsNodo[100];
        private int i;
        private int NodoEliminar;

        public clsNodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        public void Equilibrar()
        {
            NodoEliminar = default;
            i = 0;
            CargarVectorInOrder(raiz);
            raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Equilibrar(int Nodo)
        {
            NodoEliminar = Nodo;
            i = 0;
            CargarVectorInOrder(raiz);
            raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Agregar(clsNodo nuevo)
        {
            nuevo.Izquierda = null;
            nuevo.Derecha = null;
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                clsNodo NodoPadre = raiz;
                clsNodo Aux = raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (nuevo.Valor < Aux.Valor)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                }
                if (nuevo.Valor < NodoPadre.Valor)
                {
                    NodoPadre.Izquierda = nuevo;
                }
                else
                {
                    NodoPadre.Derecha = nuevo;
                }
            }
        }

        // IN ORDEN
        // lista
        public void InOrdenAsc(ListBox lst, clsNodo r)
        {
            if (r.Izquierda != null)
            {
                InOrdenAsc(lst, r.Izquierda);
            }
            lst.Items.Add(r.Valor);
            if (r.Derecha != null)
            {
                InOrdenAsc(lst, r.Derecha);
            }
        }

        public void InOrdenDes(ListBox lst, clsNodo r)
        {

            if (r.Derecha != null)
            {
                InOrdenDes(lst, r.Derecha);
            }
            lst.Items.Add(r.Valor);
            if (r.Izquierda != null)
            {
                InOrdenDes(lst, r.Izquierda);
            }
        }

        // combo
        public void InOrdenAsc(ComboBox combo, clsNodo r)
        {
            if (r.Izquierda != null)
            {
                InOrdenAsc(combo, r.Izquierda);
            }
            combo.Items.Add(r.Valor);
            if (r.Derecha != null)
            {
                InOrdenAsc(combo, r.Derecha);
            }
        }

        public void InOrdenDes(ComboBox combo, clsNodo r)
        {

            if (r.Derecha != null)
            {
                InOrdenDes(combo, r.Derecha);
            }
            combo.Items.Add(r.Valor);
            if (r.Izquierda != null)
            {
                InOrdenDes(combo, r.Izquierda);
            }
        }


        // grilla   REVISARRR
        public void InOrdenAsc(DataGridView grilla, clsNodo r)
        {
            if (r.Izquierda != null)
            {
                InOrdenAsc(grilla, r.Izquierda);
            }

            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(grilla, r.Valor, r.Nombre, r.Tramite);
            grilla.Rows.Add(r.Valor, r.Nombre, r.Tramite);

            if (r.Derecha != null)
            {
                InOrdenAsc(grilla, r.Derecha);
            }
        }

        public void InOrdenDes(DataGridView grilla, clsNodo r)
        {

            if (r.Derecha != null)
            {
                InOrdenDes(grilla, r.Derecha);
            }

            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(grilla, r.Valor, r.Nombre, r.Tramite); // Agrega las columnas necesarias
            grilla.Rows.Add(r.Valor, r.Nombre, r.Tramite);


            if (r.Izquierda != null)
            {
                InOrdenDes(grilla, r.Izquierda);
            }
        }

        // Arrbol
        private void InOrderAcs(TreeNodeCollection NodoPadre, clsNodo Raiz)
        {
            TreeNode NuevoNodo = NodoPadre.Add(Raiz.Valor.ToString());
            if (Raiz.Izquierda != null) InOrderAcs(NuevoNodo.Nodes, Raiz.Izquierda);
            if (Raiz.Derecha != null) InOrderAcs(NuevoNodo.Nodes, Raiz.Derecha);
        }

        // Recorridos
        public void RecorrerInOrdenAsc(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenAsc(lista, raiz);
        }
        public void RecorrerInOrdenAsc(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenAsc(combo, raiz);
        }
        public void RecorrerInOrdenAsc(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenAsc(grilla, raiz);
        }
        public void RecorrerInOrdenAsc(TreeView Tree)
        {
            Tree.Nodes.Clear();
            InOrderAcs(Tree.Nodes, raiz);
        }

        public void RecorrerInOrdenDes(ListBox lista)
        {
            lista.Items.Clear();
            InOrdenDes(lista, raiz);
        }
        public void RecorrerInOrdenDes(ComboBox combo)
        {
            combo.Items.Clear();
            InOrdenDes(combo, raiz);
        }
        public void RecorrerInOrdenDes(DataGridView grilla)
        {
            grilla.Rows.Clear();
            InOrdenDes(grilla, raiz);
        }



        // POST ORDEN
        // lista
        public void PreOrden(ListBox lst, clsNodo r)
        {
            lst.Items.Add(r.Valor);
            if (r.Izquierda != null) PreOrden(lst, r.Izquierda);
            if (r.Derecha != null) PreOrden(lst, r.Derecha);
        }

        public void PostOrden(ListBox lst, clsNodo r)
        {
            if (r.Izquierda != null) PostOrden(lst, r.Izquierda);
            if (r.Derecha != null) PostOrden(lst, r.Derecha);
            lst.Items.Add(r.Valor);
        }

        // combo
        public void PostOrden(ComboBox combo, clsNodo r)
        {
            if (r.Izquierda != null) PostOrden(combo, r.Izquierda);
            if (r.Derecha != null) PostOrden(combo, r.Derecha);
            combo.Items.Add(r.Valor);
        }

        // grilla
        public void PostOrden(DataGridView grilla, clsNodo r)
        {
            if (r.Izquierda != null) PostOrden(grilla, r.Izquierda);
            if (r.Derecha != null) PostOrden(grilla, r.Derecha);
            grilla.Rows.Add(r.Valor, r.Nombre, r.Tramite);
        }

        // Recorridos
        public void RecorrerPostOrden(ListBox lista)
        {
            lista.Items.Clear();
            PostOrden(lista, raiz);
        }
        public void RecorrerPostOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PostOrden(combo, raiz);
        }
        public void RecorrerPostOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PostOrden(grilla, raiz);
        }


        // PRE ORDEN
        // combo
        public void PreOrden(ComboBox combo, clsNodo r)
        {
            combo.Items.Add(r.Valor);
            if (r.Izquierda != null) PreOrden(combo, r.Izquierda);
            if (r.Derecha != null) PreOrden(combo, r.Derecha);
        }

        // grilla
        public void PreOrden(DataGridView grilla, clsNodo r)
        {
            //Agrego una nueva fila a la grilla con los datos del nodo
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(grilla, r.Valor, r.Nombre, r.Tramite); // Agrega las columnas necesarias
            grilla.Rows.Add(r.Valor, r.Nombre, r.Tramite);

            if (r.Izquierda != null) PreOrden(grilla, r.Izquierda);
            if (r.Derecha != null) PreOrden(grilla, r.Derecha);
        }

        // Recorridos
        public void RecorrerPreOrden(ListBox lista)
        {
            lista.Items.Clear();
            PreOrden(lista, raiz);
        }
        public void RecorrerPreOrden(ComboBox combo)
        {
            combo.Items.Clear();
            PreOrden(combo, raiz);
        }
        public void RecorrerPreOrden(DataGridView grilla)
        {
            grilla.Rows.Clear();
            PreOrden(grilla, raiz);
        }


        private void CargarVectorInOrder(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierda != null)
            {
                CargarVectorInOrder(NodoPadre.Izquierda);
            }
            if (NodoPadre.Valor != NodoEliminar)
            {
                Vector[i] = NodoPadre;
                i++;
            }
            if (NodoPadre.Derecha != null)
            {
                CargarVectorInOrder(NodoPadre.Derecha);
            }
        }

        private void EquilibrarArbol(int ini, int fin)
        {
            int m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

    }
}
