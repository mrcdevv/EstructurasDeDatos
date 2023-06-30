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
    public partial class frmConsultaBaseDeDatos : Form
    {
        public frmConsultaBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos db = new clsBaseDatos();

            string sql = txtConsulta.Text;
            db.Listar(dgvDatos, sql);
        }
    }
}
