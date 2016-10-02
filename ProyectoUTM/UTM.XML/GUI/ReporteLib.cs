using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReporteLib : Form
    {
        public ReporteLib()
        {
            InitializeComponent();
        }

        private void ReporteLib_Load(object sender, EventArgs e)
        {


        }
        public ReporteLib(DataTable dt)
        {
            InitializeComponent();
            imprimeReporte(dt);
        }
        public void imprimeReporte(DataTable dt)
        {

            ReportDocument cryrpt = new ReportDocument();
            string mystr = Application.StartupPath;
            //string path = mystr.Substring(0, mystr.Length - 9);
            string path = mystr.Substring(0, mystr.Length - 16) + @"UTM.SQLite\GUI\Reportes\CRLibros.rpt";
            cryrpt.Load(path);
            cryrpt.DataSourceConnections.Clear();
            cryrpt.SetDataSource(dt);
            crvReporte.ReportSource = cryrpt;
            crvReporte.Refresh();
        }
    }
}
