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
    public partial class frmConsultaPorOperaciones : Form
    {
        public frmConsultaPorOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos db = new clsBaseDatos();
            String varSql = "SELECT * FROM LIBRO";
            switch (cbOperacion.SelectedIndex)
            {
                //diferencia
                case 0:
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tIdiomas que no tienen libros ";
                    varSql = "SELECT * FROM idioma WHERE " +
                        "IdIdioma NOT IN " + "(SELECT IdIdioma from Libro) ";
                    db.Listar(dgvDatos, varSql);
                    break;
                //Interseccion
                case 1:
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tIdiomas que si tienen libros ";
                    varSql = "SELECT * FROM Idioma WHERE " +
                        " IdIdioma IN " +
                        " (SELECT IdIdioma FROM Libro) ";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 2:
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tLibros y Autores";
                    varSql = "SELECT  Titulo, Nombre " +
                        "FROM Libro INNER JOIN Autor " +
                        "ON Libro.IdAutor = Autor.IdAutor ";

                    db.Listar(dgvDatos, varSql);
                    break;
                case 3:
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tTodos los autores de los libros";
                    varSql = "SELECT Nombre FROM Autor";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 4: //Proyeccion multiatributo
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tMuestra Pais, Titulo y Cantidad";
                    varSql = "SELECT IdPais, Titulo, Cantidad FROM Libro";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 5://seleccion con and
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tMuestra todos los libros Alemanes con su precio ";
                    varSql = "SELECT * FROM Libro " +
                        "WHERE IdPais =  5 AND Precio ";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 6://Seleccion multiatributo con operador OR
                    txtOperacion.Text = cbOperacion.Text +
                     ": \tMuestra todos los libros que su autor sea Carlos o Virginia ";
                    varSql = "SELECT * FROM Libro " +
                        "WHERE IdAutor = 2 OR IdAutor = 3 ";
                    db.Listar(dgvDatos, varSql);

                    break;

                case 7://Seleccion multiatributo por convolucion
                    txtOperacion.Text = cbOperacion.Text +
                     ": \tMuestra los libros de Alemania con cantidad mayor que 2 ";
                    varSql = "SELECT * FROM " +
                        "(SELECT  Titulo, Cantidad, IdPais, IdIdioma FROM Libro WHERE Cantidad > 2) AS X " +
                        "WHERE IdIdioma = 3 ";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 8://seleccion simple
                    txtOperacion.Text = cbOperacion.Text +
                    ": \tMuestra los libros con cantidad mayor que 5 ";
                    varSql = "SELECT Titulo FROM Libro " +
                        "WHERE Cantidad > 5 ";
                    db.Listar(dgvDatos, varSql);
                    break;
                case 9: //union
                    txtOperacion.Text = cbOperacion.Text +
                        ": \tMuestra los libros con Idoma  Hebreo y Noruego";
                    varSql = "SELECT * FROM Libro " +
                        " WHERE IdIdioma = 18 " +
                        "UNION " +
                        "SELECT * FROM Libro WHERE IdIdioma = 7";
                    db.Listar(dgvDatos, varSql);
                    break;
            }
        }
    }
}
