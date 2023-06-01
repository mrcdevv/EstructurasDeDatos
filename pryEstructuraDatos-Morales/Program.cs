using pryEstructuraDatos_Morales.EstructurasLineales;
using pryEstructuraDatos_Morales.EstructurasNoLineales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseDeDatos.frmBaseDeDatos());
        }
    }
}
