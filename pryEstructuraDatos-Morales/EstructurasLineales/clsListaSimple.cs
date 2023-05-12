using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.EstructurasLineales
{
    internal class clsListaSimple
    {

        clsNodo primero;

        public void Agregar(clsNodo nuevo)
        {
            if(primero == null)
            {
                primero = nuevo;
            }
            else
            {
                if (nuevo.Valor <= primero.Valor)
                {
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
                else
                {
                    clsNodo anterior = primero;
                    clsNodo auxiliar = primero;

                    while (nuevo.Valor > auxiliar.Valor)
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.Siguiente;

                        if (auxiliar == null)
                        {
                            break;
                        }
                    }

                    anterior.Siguiente = nuevo;
                    nuevo.Siguiente = auxiliar;
                }
            }
        }


        public void Eliminar(int codigo)
        {
            if (primero.Valor == codigo)
            {
                primero = primero.Siguiente;
            }
            else
            {
                clsNodo anterior = primero;
                clsNodo auxiliar = primero;

                while (auxiliar.Valor != codigo)
                {
                    anterior = auxiliar;
                    auxiliar = auxiliar.Siguiente;
                }

                anterior.Siguiente = auxiliar.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Valor, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Valor + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Valor);
                aux = aux.Siguiente;
            }
        }

    }
}
