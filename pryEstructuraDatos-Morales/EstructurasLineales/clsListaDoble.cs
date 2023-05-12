using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    internal class clsListaDoble
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public void Agregar(clsNodo nuevo)
        {

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                if (nuevo.Valor <= primero.Valor)
                {
                    nuevo.Siguiente = primero;
                    primero.Anterior = nuevo;
                    primero = nuevo;
                }
                else
                {
                    if (nuevo.Valor > ultimo.Valor)
                    {
                        ultimo.Siguiente = nuevo;
                        nuevo.Anterior = ultimo;
                        ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo anterior = primero;
                        clsNodo auxiliar = primero;

                        while(nuevo.Valor > auxiliar.Valor)
                        {
                            anterior = auxiliar;
                            auxiliar = auxiliar.Siguiente;
                        }

                        anterior.Siguiente = nuevo;
                        nuevo.Siguiente = auxiliar;
                        nuevo.Anterior = anterior;
                        auxiliar.Anterior = nuevo;
                    }
                }
            }
        }

        public void Eliminar(int codigo)
        {

            // Si el dato que borro es el unico de la lista
            if (primero.Valor == codigo && ultimo == primero)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                // Si el que borro es el primero de la lista
                if (primero.Valor == codigo)
                {
                    primero = primero.Siguiente;
                    primero.Anterior = null;
                } 
                else
                {
                    // Si el que borro es el ultimo de la lista
                    if (ultimo.Valor == codigo) 
                    {
                        ultimo = ultimo.Anterior;
                        ultimo.Siguiente = null;
                    }

                    // Intermedio
                    else
                    {
                        clsNodo anterior = primero;
                        clsNodo auxiliar = primero;

                        while(auxiliar.Valor != codigo)
                        {
                            anterior = auxiliar;
                            auxiliar = auxiliar.Siguiente;
                        }

                        auxiliar = auxiliar.Siguiente;
                        auxiliar.Anterior = anterior;
                        anterior.Siguiente = auxiliar;

                    }

                }
            }
        }

        public void RecorrerAsc(DataGridView Grilla)
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Valor, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Valor, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }


        public void RecorrerAsc(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Valor + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDesc(ListBox Lista)
        {
            clsNodo aux = ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Valor + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerAsc(ComboBox Combo)
        {
            clsNodo aux = primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Valor);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDesc(ComboBox Combo)
        {
            clsNodo aux = ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Valor);
                aux = aux.Anterior;
            }
        }
    }
}
