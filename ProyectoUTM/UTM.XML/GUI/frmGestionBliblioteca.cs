using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.XML.GUI
{
    public partial class frmGestionBliblioteca : Form
    {
        public frmGestionBliblioteca()
        {
            InitializeComponent();
        }
        DataSet dsReporte = new DataSet();
        private void frmGestionBliblioteca_Load(object sender, EventArgs e)
        {
            dtgListado.DataSource = this.Listar();
        }
        private DataTable Listar()
        {
            DataSet dsBibliografia = new DataSet();
            string Rutacompleta = Application.StartupPath.ToString();
            string ruta = Rutacompleta.Substring(0, Rutacompleta.Length - 16) + @"UTM.XML\bin\XMLBibliografia.xml";
           
            dsBibliografia.ReadXml(ruta);
            return dsBibliografia.Tables[0];
        }
        private DataTable Buscar(string Nombre, string isbn)
        {
            DataTable dsBibliografia = new DataTable();
            DataTable dsTemporal = new DataTable();
            dsBibliografia = this.Listar();
            dsTemporal = this.Listar();
            dsTemporal.Clear();

            if (Nombre.Trim().Length > 0 || isbn.Trim().Length > 0)
            {
                foreach (DataRow r in dsBibliografia.Rows)
                {
                    if (r["Nombre"].ToString() == Nombre || r["ISBN"].ToString() == isbn)
                    {
                        dsTemporal.ImportRow(r);
                    }
                }
            }
            else
            {
                dsTemporal = this.Listar();
            }

            return dsTemporal;
        }
      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgListado.DataSource = this.Buscar(txtNombre.Text.Trim(), txtISBN.Text.Trim());
            ds.Tables.Add(dtgListado.DataMember);
            dsReporte = ds;
        }
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtISBN.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dsReporte.Tables[0].Rows.Count != 0)
            {
                ReporteLib oReporteAlumno = new ReporteLib(dsReporte.Tables[0]);
                oReporteAlumno.ShowDialog();
            }
            else
            {
                MessageBox.Show("Favor de realizar una busqueda");
            }
        }

        private void dtgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (this.dtgListado.Columns[e.ColumnIndex].Name == "editar")
                {
                   

                     string id = Convert.ToString(this.dtgListado.Rows[e.RowIndex].Cells["ISBN"].Value);

                   // GUI.Editar frmEditar = new GUI.Editar(this.Buscar("", id));
                   // frmSQLiteEditar ofrmSQLiteEditar = new frmSQLiteEditar("Edicion", oAlumnoBO);
                     GUI.Editar frmEditar = new GUI.Editar(this.Buscar("",id));
                    frmEditar.ShowDialog();
                    dtgListado.DataSource = null;

                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.Editar frmEditar = new GUI.Editar();
            frmEditar.ShowDialog();
            dtgListado.DataSource = this.Listar();
        }
    }
}
