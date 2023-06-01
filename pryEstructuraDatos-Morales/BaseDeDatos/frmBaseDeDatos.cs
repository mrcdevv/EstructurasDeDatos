using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos_Morales.BaseDeDatos
{
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos db = new clsBaseDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Titulo FROM Libro";
            db.Listar(dgvDatos, sql);
        }

        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Titulo, Año FROM Libro";
            db.Listar(dgvDatos, sql);
        }
        private void btnProyeccionJuntar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Libro WHERE precio >= 900";
            db.Listar(dgvDatos, sql);
        }

        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Libro WHERE precio >= 900 AND precio <= 950";
            db.Listar(dgvDatos, sql);
        }

        private void btnSeleccionConv_Click(object sender, EventArgs e)
        {

        }

        private void btnAlgUnion_Click(object sender, EventArgs e)
        {
            string sql = "" +
                "SELECT * FROM Libro WHERE precio >= 900 " +
                "UNION " +
                "SELECT * FROM libro WHERE <= 951 ";
            db.Listar(dgvDatos, sql);
        }

        private void btnAlgInterseccion_Click(object sender, EventArgs e)
        {

        }

        private void btnAlgeDiferencia_Click(object sender, EventArgs e)
        {

        }
    }
}
