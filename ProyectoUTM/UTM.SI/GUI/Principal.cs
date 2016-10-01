using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UTM.SI.GUI
{
    public partial class Principal : Form
    {
        

        public Principal()
        {
            InitializeComponent();
            CargaMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CargaMenuArchivo()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("Practia Parcial 1");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Practia Parcial 1")
                {
                    UTM.Archivo.GUI.frmArchivo ofrmArchivo = new UTM.Archivo.GUI.frmArchivo();
                    showwindow(ofrmArchivo);                 
                }

            };
            nbbArchivo.RelatedControl = treeView;     
        }

 
        public void CargaMenuXml()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("XML");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "XML")
                {
                   UTM.XML.GUI.frmXML ofrmXML = new UTM.XML.GUI.frmXML();
                    showwindow(ofrmXML);
                }

            };
            nbbXML.RelatedControl = treeView;   
        }
        public void Agenda()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("SQLite");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "SQLite")
                {
                    UTM.SQLite.GUI.SLQLite ofrmSQLite = new UTM.SQLite.GUI.SLQLite();
                   showwindow(ofrmSQLite);
                }

            };
            nbbSQLite.RelatedControl = treeView;     
        }
        public void CargaMenuSqlite()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("Contactos");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Contactos")
                {
                    UTM.SQLite.GUI.ABCContactos Agenda = new UTM.SQLite.GUI.ABCContactos();
                    showwindow(Agenda);
                }

            };
            nbbAgenda.RelatedControl = treeView;
        }


        public void CargaMenuTraductor()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("Traductor");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Traductor")
                {
                    UTM.Archivo.bin.frmTraductor ofrmArchivo = new UTM.Archivo.bin.frmTraductor();
                    showwindow(ofrmArchivo);
                }

            };
            nbbTraductor.RelatedControl = treeView; 
        }
        public void Blibloteca()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("XML Bibliteca");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "XML Bibliteca")
                {
                    UTM.XML.GUI.frmGestionBliblioteca frmBiblioteca = new UTM.XML.GUI.frmGestionBliblioteca();
                    showwindow(frmBiblioteca);
                }

            };
            nbbXMLPractica.RelatedControl = treeView;
        }
        public void CargaMenu() 
        {
            CargaMenuArchivo();
            CargaMenuXml();
            CargaMenuSqlite();
            CargaMenuTraductor();
            Blibloteca();
            Agenda();
        }
        private void showwindow(Form ventanaMostrar)
        {
            bool found = false;
            Form[] charr = this.MdiChildren;
            if (charr.Length == 0)
            {
                ventanaMostrar.MdiParent = this;
                ventanaMostrar.Show();
                ventanaMostrar.WindowState = FormWindowState.Maximized;
            }
            else
            {
                foreach (Form chform in charr)
                {
                    if ((chform.Text) == (ventanaMostrar.Text))
                    {
                        chform.Activate();
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (found == false)
                {
                    ventanaMostrar.MdiParent = this;
                    ventanaMostrar.Show();
                    ventanaMostrar.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void navigateBarButton1_OnNavigateBarButtonSelected(MT.WindowsUI.NavigationPane.NavigateBarButtonEventArgs e)
        {

        }

        private void nbbXMLPractica_OnNavigateBarButtonSelected(MT.WindowsUI.NavigationPane.NavigateBarButtonEventArgs e)
        {

        }

        private void nbbSQLite_OnNavigateBarButtonSelected(MT.WindowsUI.NavigationPane.NavigateBarButtonEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
      
    }
}
