using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoEmail;
using UTM.SQLite.Service;
using UTM.SQLite.BO;
namespace UTM.SQLite.GUI
{
    public partial class Correo : Form
    {
        public Correo()
        {
            InitializeComponent();
        }
        public Correo(string operacion, AgendaBO oAgendaBO)
        {
            InitializeComponent();

            if (operacion == "correo")
            {
                BuscarAgenda(oAgendaBO);
            }

        }
        string Destinatario;
        public void BuscarAgenda(AgendaBO oAgendaBO)
        {
            //     AgendaBO AgendaBO = new AgendaBO();

            CtrlAgenda oCtrlAgenda = new CtrlAgenda();
            DataTable dt = oCtrlAgenda.BusquedaContactos(oAgendaBO).Tables[0];
            if (dt.Rows.Count != 0)
            {
                Destinatario = dt.Rows[0]["CorreoElectronico"].ToString();
                txtMensaje.Text = dt.Rows[0]["CorreoElectronico"].ToString();
            }
            else
            {
                this.Close();
            }
          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarEmail();
        }
        private void EnviarEmail()
        {

            EnviarEmail x = new EnviarEmail();
            string usu = "huellitasunidas@gmail.com";
            string pass = "proyecto3bhuellitas";
            string Encabezado = "Muchas Felicidades";
            string Emisor = "huellitasunidas@gmail.com";
            

            bool exito = x.EnviarMail(Destinatario, Encabezado, txtMensaje.Text.Trim(), Emisor, usu, pass);
            if (exito == true)
            {
                MessageBox.Show("Mensaje enviado");
            }
            else
            {
                MessageBox.Show("Intenta de nuevo");
            }


        }
    }
}
