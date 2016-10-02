using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTM.SQLite.DAO;
namespace UTM.SQLite.Service
{
    public class CtrlLibro
    {
        LibrosDAO oAlumnoDao = new LibrosDAO();

        public DataSet BusquedaLibro(object obj)
        {
            DataSet ds = new DataSet();
            ds = oAlumnoDao.BusquedaLibro(obj);
            return ds;
        }

        public int creaLibro(object obj)
        {
            int i = oAlumnoDao.AltaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaLibro(object obj)
        {
            int i = oAlumnoDao.modificaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaLibro(object obj)
        {
            int i = oAlumnoDao.eliminaLibro(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

    }
}
