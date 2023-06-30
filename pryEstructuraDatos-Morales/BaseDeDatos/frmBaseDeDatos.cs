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
            string sql = "SELECT Titulo, Nombre FROM Libro INNER JOIN Pais ON Libro.IdPais = Pais.IdPais";
            db.Listar(dgvDatos, sql);
            
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
            string sql = "SELECT * FROM (SELECT * FROM Libro WHERE IdIdioma > 1) as X WHERE IdPais = 2";
            db.Listar(dgvDatos, sql);
        }

        private void btnAlgUnion_Click(object sender, EventArgs e)
        {
            string sql = "" +
                "SELECT * FROM Libro WHERE IdIdioma = 2 " +
                "UNION " +
                "SELECT * FROM Libro where IdIdioma = 3 ";
            db.Listar(dgvDatos, sql);
        }

        private void btnAlgInterseccion_Click(object sender, EventArgs e)
        {
            string sql = "" +
                "SELECT * FROM Libro WHERE IdIdioma = 3 AND IdLibro IN " +
                "(SELECT IdLibro FROM Libro WHERE IdPais = 2) " +
                "ORDER BY 1 ASC";
            db.Listar(dgvDatos, sql);

        }

        private void btnAlgeDiferencia_Click(object sender, EventArgs e)
        {
            string sql = "" +
                "SELECT * FROM Libro WHERE IdIdioma = 3 AND IdLibro not in " +
                "(SELECT IdLibro FROM Libro WHERE IdPais = 2) " +
                "ORDER BY 1 ASC";
            db.Listar(dgvDatos, sql);

        }

        private void frmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
