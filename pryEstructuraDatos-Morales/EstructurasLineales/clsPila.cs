using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    internal class clsPila
    {
        public clsNodo primero;

        public void Agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                nuevo.Anterior = primero;
                primero = nuevo;
            }
        }

        public void Eliminar()
        {
            if (primero != null)
            {
                primero = primero.Anterior;

            }
        }

        public void Recorrer(DataGridView grilla)
        {
            grilla.Rows.Clear();
            clsNodo auxiliar = primero;
            while (auxiliar != null)
            {
                grilla.Rows.Add(auxiliar.Valor, auxiliar.Nombre, auxiliar.Tramite);
                auxiliar = auxiliar.Anterior;
            }
        }

        public void Recorrer(ListBox lista)
        {
            lista.Items.Clear();
            clsNodo auxiliar = primero;
            while (auxiliar != null)
            {
                lista.Items.Add(auxiliar.Valor + " " + auxiliar.Nombre + " " + auxiliar.Tramite);
                auxiliar = auxiliar.Anterior;
            }
        }

        public void Recorrer(ComboBox combo)
        {
            combo.Items.Clear();
            clsNodo auxiliar = primero;
            while (auxiliar != null)
            {
                combo.Items.Add(auxiliar.Nombre);
                auxiliar = auxiliar.Anterior;
            }
        }

    }
}
