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
    public partial class ABCContactos : Form
    {
        public ABCContactos()
        {
            InitializeComponent();
            Buscar();
        }
       
        DataSet dsReporte = new DataSet();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            AgendaBO oAgendaBO = new AgendaBO();
            CtrlAgenda oContactosCtrl = new CtrlAgenda();

            if (txtNombre.Text.Trim().Length != 0)
            {
                oAgendaBO.Nombre = txtNombre.Text.Trim();
            }
            if (txtApellidos.Text.Trim().Length != 0)
            {
                oAgendaBO.Apellidos = txtApellidos.Text.Trim();
            }
            if (txtEdad.Text.Trim().Length != 0)
            {
                oAgendaBO.Edad = txtEdad.Text.Trim();
            }
            if (txtTelefono.Text.Trim().Length != 0)
            {
                oAgendaBO.Telefono = txtTelefono.Text.Trim();
            }
            if (txtCorreo.Text.Trim().Length != 0)
            {
                oAgendaBO.CorreoElectronico = txtCorreo.Text.Trim();
            }

            dsReporte = oContactosCtrl.BusquedaContactos(oAgendaBO);
            dtgContactos.AutoGenerateColumns = false;
            dtgContactos.DataSource = dsReporte.Tables[0];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void ABCContactos_Load(object sender, EventArgs e)
        {
            dtgContactos.Columns[0].Visible = false;
        }
        private void dtgContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtFechaCumpleaños.Clear();
            txtTelefono.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.EditarAgenda ofrmSQLiteEditar = new GUI.EditarAgenda("Nuevo");
            ofrmSQLiteEditar.ShowDialog();
            dtgContactos.DataSource = null;
        }

        private void dtgContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void Formulario_Primario(object sender, FormClosedEventArgs e)
        {
            Buscar();
           
        }

       

        private void dtgContactos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la acción seleccionada 
            if (e.RowIndex > -1)
            {
                if (this.dtgContactos.Columns[e.ColumnIndex].Name == "editar")
                {
                    AgendaBO oLibroBO = new AgendaBO();

                    oLibroBO.IDagenda = Convert.ToInt32(this.dtgContactos.Rows[e.RowIndex].Cells["IDagenda"].Value);

                    GUI.EditarAgenda ofrmSQLiteEditar = new GUI.EditarAgenda("Edicion", oLibroBO);
                    ofrmSQLiteEditar.FormClosed += new FormClosedEventHandler(Formulario_Primario);
                    ofrmSQLiteEditar.ShowDialog();
                    //Método para disparar la acción de buscar y llenar la tabla al cerrar el formulario primario.
                 
                    

                }
                if (this.dtgContactos.Columns[e.ColumnIndex].Name == "Actividades")
                {
                    AgendaBO oLibroBO = new AgendaBO();

                    oLibroBO.IDagenda = Convert.ToInt32(this.dtgContactos.Rows[e.RowIndex].Cells["IDagenda"].Value);


                    GUI.RegistroActividades frmRegistroActividades = new GUI.RegistroActividades("Actividades", oLibroBO);
                    frmRegistroActividades.FormClosed += new FormClosedEventHandler(Formulario_Primario);
                    frmRegistroActividades.ShowDialog();
                   

                }

                if (this.dtgContactos.Columns[e.ColumnIndex].Name == "correo")
                {
                    AgendaBO oLibroBO = new AgendaBO();

                    oLibroBO.IDagenda = Convert.ToInt32(this.dtgContactos.Rows[e.RowIndex].Cells["IDagenda"].Value);


                    GUI.Correo frmRegistroActividades = new GUI.Correo("correo", oLibroBO);
                     frmRegistroActividades.FormClosed += new FormClosedEventHandler(Formulario_Primario);
                    frmRegistroActividades.ShowDialog();
                  

                }

            }

        }



    }
}