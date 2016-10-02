using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTM.SQLite.BO;
using UTM.SQLite.Service;
namespace UTM.SQLite.GUI
{
    public partial class SLQLite : Form
    {
        DataSet dsReporte = new DataSet();
        public SLQLite()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            LibroBO oLibroBO = new LibroBO();
            CtrlLibro oLibroCtrl = new CtrlLibro();
            if (txtISBN.Text.Trim().Length != 0)
            {
                oLibroBO.ISBN = Convert.ToInt32(txtISBN.Text.Trim());
            }
            if (txtAutor.Text.Trim().Length != 0)
            {
                oLibroBO.Autor = txtAutor.Text.Trim();
            }
            if (txtNombre.Text.Trim().Length != 0)
            {
                oLibroBO.Titulo = txtNombre.Text.Trim();
            }
            if (txtEditorial.Text.Trim().Length != 0)
            {
                oLibroBO.Editorial = txtEditorial.Text.Trim();
            }
            if (txtPrecio.Text.Trim().Length != 0)
            {
                oLibroBO.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
            }
            dsReporte = oLibroCtrl.BusquedaLibro(oLibroBO);
            dgvAlumno.AutoGenerateColumns = false;
            dgvAlumno.DataSource = dsReporte.Tables[0];
        }

        private void SLQLite_Load(object sender, EventArgs e)
        {

        }

        private void dgvAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dgvAlumno.Columns[e.ColumnIndex].Name == "editar")
                {
                    LibroBO oLibroBO = new LibroBO();

                    oLibroBO.ISBN = Convert.ToInt32(this.dgvAlumno.Rows[e.RowIndex].Cells["ISBN"].Value);
                    GUI.Editar ofrmSQLiteEditar = new GUI.Editar("Edicion", oLibroBO);
                    ofrmSQLiteEditar.ShowDialog();
                    dgvAlumno.DataSource = null;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.Editar ofrmSQLiteEditar = new GUI.Editar("Nuevo");
            ofrmSQLiteEditar.ShowDialog();
            dgvAlumno.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsReporte.Tables[0].Rows.Count != 0)
                {
                    ReporteLibro oReporteAlumno = new ReporteLibro(dsReporte.Tables[0]);
                    oReporteAlumno.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Favor de realizar una busqueda");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtAutor.Clear();
            txtEditorial.Clear();
            txtISBN.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();

        }
    }
}
