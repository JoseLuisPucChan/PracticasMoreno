using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.SQLite.GUI
{
    public partial class AgendaElectronica : Form
    {
        public AgendaElectronica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABCContactos open = new ABCContactos();
            open.ShowDialog();
            
        }
    }
}
