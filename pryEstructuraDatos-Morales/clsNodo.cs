using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos_Morales
{
    internal class clsNodo
    {

        private int valor;
        private string nombre;
        private string tramite;
        private clsNodo siguiente;
        private clsNodo derecha;
        private clsNodo anterior;
        private clsNodo izquierda;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }

        public clsNodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public clsNodo Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }

        public clsNodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public clsNodo Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }


    }
}
