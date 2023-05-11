using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    internal class clsCola
    {
        public clsNodo primero;
        public clsNodo ultimo;

        public void Agregar(clsNodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Anterior = nuevo;
                ultimo = nuevo;
            }
        }

        public void Eliminar()
        {
            if (primero != null)
            {
                primero = primero.Anterior;
            }
            else
            {
                primero = null;
                ultimo = null;
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
            while(auxiliar != null)
            {
                combo.Items.Add(auxiliar.Nombre);
                auxiliar = auxiliar.Anterior;
            }
        }
    }
}
