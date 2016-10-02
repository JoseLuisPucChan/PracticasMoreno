using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTM.SQLite.BO
{
    public class LibroBO
    {
        int iSBN;

        public int ISBN
        {
            get { return iSBN; }
            set { iSBN = value; }
        }
        string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        string editorial;

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        string imagen;

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}
