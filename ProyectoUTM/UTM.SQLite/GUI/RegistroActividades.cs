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
    public partial class RegistroActividades : Form
    {
        AgendaBO oAgenda = new AgendaBO();
        public RegistroActividades()
        {
            InitializeComponent();
        }
        public RegistroActividades(string operacion, AgendaBO oAgendaBO)
        {
            InitializeComponent();

            if (operacion == "Actividades")
            {
                BuscarAgenda(oAgendaBO);
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
            }
            else
            {
                this.Close();
            }
            oAgendaBO.IdContacto = Convert.ToInt32(txtid.Text.Trim());

            DataTable dtActividad = oCtrlAgenda.BusquedaAcctividad(oAgendaBO).Tables[0];
            dataGridView1.DataSource = dtActividad;



        }
        private void RegistroActividades_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            oAgenda.IdContacto = Convert.ToInt32(txtid.Text.Trim());
            BuscarAgenda(oAgenda);
            Close();
        }
        public void eliminar()
        {
            AgendaBO oAgendaBO = new AgendaBO();
            CtrlAgenda Servicio = new CtrlAgenda();
            oAgendaBO.IDActivida = Convert.ToInt32(txtIDactividad.Text.Trim());
            int i = Servicio.eliminaActividad(oAgendaBO);
            if (i == 1)
            {
                MessageBox.Show("Los datos se eliminaron correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se eliminaron, intenta de nuevo");
            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtIDactividad.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["idActividad"].Value);
                txtNombreA.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["NombreActividad"].Value);
                txtDescripcion.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Descripcion"].Value);
                txtLugar.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Luegar"].Value);
                dtFechaActividad.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["FechaActividad"].Value);
            }
            catch(Exception ex)
            {
                
            }

        

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregar();
            oAgenda.IdContacto = Convert.ToInt32(txtid.Text.Trim());
            BuscarAgenda(oAgenda);
            Close();
        }
        public void agregar()
        {




            string fecha = dtFechaActividad.Value.Day + "/" + dtFechaActividad.Value.Month + "/" + dtFechaActividad.Value.Year;
                AgendaBO oAgendaBO = new AgendaBO();
                CtrlAgenda oServicio = new CtrlAgenda();
                oAgendaBO.IdContacto =Convert.ToInt32( txtid.Text.Trim()); 
                oAgendaBO.NombreActividad = txtNombreA.Text.Trim();
                oAgendaBO.Descripcion = txtDescripcion.Text.Trim();
                oAgendaBO.Lugar = txtLugar.Text.Trim();
                oAgendaBO.FechanActividad = fecha;
                oServicio.creaA(oAgendaBO);
                MessageBox.Show("El Libro se guardo correctamete");
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
