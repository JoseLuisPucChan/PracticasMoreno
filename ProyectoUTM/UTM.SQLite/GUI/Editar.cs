using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTM.SQLite.BO;
using UTM.SQLite.Service;
namespace UTM.SQLite.GUI
{
    public partial class Editar : Form
    {
        public Editar(string operación)
        {
            InitializeComponent();
            if (operación == "Nuevo")
            {
                limpiar();
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
            }
        }
        public Editar(string operacion, LibroBO oLibroBO)
        {
            InitializeComponent();
           
            if (operacion == "Edicion")
            {
                btnGuardar.Visible = false;
               // btnGuardarSeguir.Visible = false;
                this.BuscarLibro(oLibroBO);
            }

        }
        public void limpiar()
        {
            txtISBN.Clear();
            txtNombre.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtPrecio.Clear();
        }
        public void BuscarLibro(LibroBO oLibroBO)
        {
            //AlumnoBO oAlumnoBO = new AlumnoBO();
            CtrlLibro CtrlLibro = new CtrlLibro();
            DataTable dt = CtrlLibro.BusquedaLibro(oLibroBO).Tables[0];
            if (dt.Rows.Count != 0)
            {
                txtISBN.Text = dt.Rows[0]["ISBN"].ToString();
                txtNombre.Text = dt.Rows[0]["Titulo"].ToString();
                txtAutor.Text = dt.Rows[0]["Autor"].ToString();
                txtEditorial.Text = dt.Rows[0]["Editorial"].ToString();
                txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
                pbImagen.Image = this.AbrirImagen(dt.Rows[0]["Imagen"].ToString());
            }
            else
            {
                this.Close();
            }
        }
        public void agregar()
        {
         
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtAutor.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Autor \n";
            }
            if (txtEditorial.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Editorial \n";
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Precio \n";
            }

            if (mensaje.Trim().Length == 0)
            {
                LibroBO oLibroBO = new LibroBO();
                CtrlLibro oServicio = new CtrlLibro();
                oLibroBO.Titulo = txtNombre.Text.Trim();
                oLibroBO.Autor = txtAutor.Text.Trim();
                oLibroBO.Editorial = txtEditorial.Text.Trim();
                oLibroBO.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
                GuardarImagen();
                oLibroBO.Imagen = imagen;
                oServicio.creaLibro(oLibroBO);
                MessageBox.Show("El Libro se guardo correctamete");
            }
            else
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n" + mensaje);
            }


        }
        string imagen;
        public void GuardarImagen()
        {
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();
            //convierte la imagen a string
            imagen = Convert.ToBase64String(imageBytes);
           
        }
        public void modificar()
        {
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtAutor.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Autor \n";
            }
            if (txtEditorial.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Editorial \n";
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Precio \n";
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Teléfono \n";
            }

            if (mensaje.Trim().Length == 0)
            {
                LibroBO oLibroBO = new LibroBO();
                CtrlLibro LibroCtrl = new CtrlLibro();
                oLibroBO.ISBN = Convert.ToInt32(txtISBN.Text.Trim());
                oLibroBO.Titulo = txtNombre.Text.Trim();
                oLibroBO.Autor = txtAutor.Text.Trim();
                oLibroBO.Editorial = txtEditorial.Text.Trim();
                oLibroBO.Precio = Convert.ToInt32(txtPrecio.Text.Trim());
                LibroCtrl.modificaLibro(oLibroBO);
                MessageBox.Show("El libro se modifico correctamete");
            }
            else
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n" + mensaje);
            }


        }
        public void eliminar()
        {
            LibroBO oLibroBO = new LibroBO();
            CtrlLibro oCtrlLibro = new CtrlLibro();
            oLibroBO.ISBN = Convert.ToInt32(txtISBN.Text.Trim());
            int i = oCtrlLibro.eliminaLibro(oLibroBO);
            if (i == 1)
            {
                MessageBox.Show("Los datos se eliminaron correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron, intenta de nuevo");
            }

        }



        private void Editar_Load(object sender, EventArgs e)
        {

        }
        private Image AbrirImagen(string imagen)
        {
            //convirte el string base64 en un arreglo de bytes 
            byte[] imageBytes = Convert.FromBase64String(imagen);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Image img = Image.FromStream(ms, true);
            return img;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregar();
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            Close();
        }
     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaImagen();
        }
        private void CargaImagen()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\users\public\pictures";
            open.Filter = "JPG [*.jpg] |*.jpg|JPEG [*.jpeg]|*.jpeg|PNG[*.png]|*.png|BMP|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string ruta = open.FileName;
                pbImagen.Image = Image.FromFile(ruta);
            }

        }
       

    }

}
