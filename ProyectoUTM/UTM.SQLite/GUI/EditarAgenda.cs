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
    public partial class EditarAgenda : Form
    {
        public EditarAgenda(string operación)
        {
            InitializeComponent();
            if (operación == "Nuevo")
            {
                Limpiar();
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnGuardar.Visible = true;
            }
        }
        public EditarAgenda(string operacion, AgendaBO oAgendaBO)
        {
            InitializeComponent();
           
            if (operacion == "Edicion")
            {
                Limpiar();
                btnGuardar.Visible = false;
                BuscarAgenda(oAgendaBO);
                groupBox1.Text = "Editar contacto";
            }

        }
        public void BuscarAgenda(AgendaBO oAgendaBO)
        {
       //     AgendaBO AgendaBO = new AgendaBO();
          
            CtrlAgenda oCtrlAgenda = new CtrlAgenda();
            DataTable dt = oCtrlAgenda.BusquedaContactos(oAgendaBO).Tables[0];
            if (dt.Rows.Count != 0)
            {
                txtid.Text = dt.Rows[0]["IDagenda"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtApellidos.Text = dt.Rows[0]["Apellidos"].ToString();
                txtEdad.Text = dt.Rows[0]["Edad"].ToString();
                txtTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                txtCorreo.Text = dt.Rows[0]["CorreoElectronico"].ToString();
              dtpFechaNacimiento.Value = Convert.ToDateTime(dt.Rows[0]["FechaNacimiento"].ToString());
            }
            else
            {
                this.Close();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
      
        private void EditarAgenda_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
           
            txtTelefono.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
            Close();
        }
        public void agregar()
        {
          
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtApellidos.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellidos \n";
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo Eléctronico \n";
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Teléfono \n";
            }
             if (txtEdad.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la del Contacto Edad \n";
            }


            if (mensaje.Trim().Length == 0)
            {
                string fecha = dtpFechaNacimiento.Value.Day + "/" + dtpFechaNacimiento.Value.Month + "/"+dtpFechaNacimiento.Value.Year;
                AgendaBO oAgendaBO = new AgendaBO();
                CtrlAgenda oServicio = new CtrlAgenda();
                oAgendaBO.Nombre = txtNombre.Text.Trim();
                oAgendaBO.Apellidos = txtApellidos.Text.Trim();
                oAgendaBO.Edad = txtEdad.Text.Trim();
                oAgendaBO.Telefono = txtTelefono.Text.Trim();
                oAgendaBO.CorreoElectronico = txtCorreo.Text.Trim();
                oAgendaBO.FechaNacimiento1 = fecha;
                oServicio.creaContacto(oAgendaBO);
                MessageBox.Show("El Libro se guardo correctamete");
            }
            else
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n" + mensaje);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
            Close();
        }
        public void modificar()
        {
            string mensaje = "";
            if (txtNombre.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Nombre \n";
            }
            if (txtApellidos.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Apellidos \n";
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce el Correo Eléctronico \n";
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la Teléfono \n";
            }
            if (txtEdad.Text.Trim().Length == 0)
            {
                mensaje = mensaje + "Introduce la del Contacto Edad \n";
            }

            if (mensaje.Trim().Length == 0)
            {
                string fecha = dtpFechaNacimiento.Value.Day + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Year;
                AgendaBO oAgendaBO = new AgendaBO();
                CtrlAgenda oServicio = new CtrlAgenda();
                oAgendaBO.IDagenda = Convert.ToInt32(txtid.Text.Trim());
                oAgendaBO.Nombre = txtNombre.Text.Trim();
                oAgendaBO.Apellidos = txtApellidos.Text.Trim();
                oAgendaBO.Edad = txtEdad.Text.Trim();
                oAgendaBO.Telefono = txtTelefono.Text.Trim();
                oAgendaBO.CorreoElectronico = txtCorreo.Text.Trim();
                oAgendaBO.FechaNacimiento1 = fecha;
                oServicio.modificaContacto(oAgendaBO);
                MessageBox.Show("El libro se modifico correctamete");
            }
            else
            {
                MessageBox.Show("Favor de ingresar los siguientes datos:\n" + mensaje);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            Close();
        }
        public void eliminar()
        {
            AgendaBO oAgendaBO = new AgendaBO();
            CtrlAgenda Servicio = new CtrlAgenda();
            oAgendaBO.IDagenda = Convert.ToInt32(txtid.Text.Trim());
            int i = Servicio.eliminaContacto(oAgendaBO);
            if (i == 1)
            {
                MessageBox.Show("Los datos se eliminaron correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron, intenta de nuevo");
            }

        }

    }
}
