using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Reto2.Reporte
{
    public partial class ReporteCinemex : Form
    {
        public DataSet ds = new DataSet();
        public string tabla = "";
        public ReporteCinemex()
        {
            InitializeComponent();
        }

        public ReporteCinemex(DataSet dst, string tb)
        {
            InitializeComponent();
            ds = dst;
            tabla = tb;
        }

        private void ReporteCinemex_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            if (tabla == "Todos")
            {
                ReportDocument cryrpt = new ReportDocument();
                string mystr = Application.StartupPath;
                //string path = mystr.Substring(0, mystr.Length - 9);
                string path = mystr.Substring(0, mystr.Length - 15) + @"Reto2\Reporte\crCinemex.rpt";
                cryrpt.Load(path);
                cryrpt.DataSourceConnections.Clear();
                cryrpt.SetDataSource(ds);
                crvReporte.ReportSource = cryrpt;
                crvReporte.Refresh();
            }
            else
            {
                ReportDocument cryrpt = new ReportDocument();
                string mystr = Application.StartupPath;
                //string path = mystr.Substring(0, mystr.Length - 9);
                string path = mystr.Substring(0, mystr.Length - 15) + @"Reto2\Reporte\crCinemex.rpt";
                cryrpt.Load(path);
                cryrpt.DataSourceConnections.Clear();
                cryrpt.SetDataSource(ds.Tables[tabla]);
                crvReporte.ReportSource = cryrpt;
                crvReporte.Refresh();
            }
        }

    }
}
