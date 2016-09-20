using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM.XML.Reportes
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
        public void Reportes()
        {
          
            //Datas set

            DSAlumno dataset = new DSAlumno();

            //Pasamis los valores
            CRAlumno reporte_datos = new CRAlumno();
            //Pasamos los valores
          //  registro.Fill(dataset, "VistaMascotas");
            reporte_datos.SetDataSource(dataset);

            //Mostramos el reporte
            crystalReportViewer1.ReportSource = reporte_datos;
         

        }
    }
}
