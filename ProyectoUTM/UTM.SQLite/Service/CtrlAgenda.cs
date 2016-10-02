using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTM.SQLite.DAO;
namespace UTM.SQLite.Service
{
    class CtrlAgenda
    {

        AgendaDAO oAlumnoDao = new AgendaDAO();

        public DataSet BusquedaContactos(object obj)
        {
            DataSet ds = new DataSet();
            ds = oAlumnoDao.BusquedaContactos(obj);
            return ds;
        }
        public DataSet BusquedaAcctividad(object obj)
        {
            DataSet ds = new DataSet();
            ds = oAlumnoDao.BusquedaActividades(obj);
            return ds;
        }
        public int creaContacto(object obj)
        {
            int i = oAlumnoDao.AltaContacto(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int creaA(object obj)
        {
            int i = oAlumnoDao.AltaA(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaContacto(object obj)
        {
            int i = oAlumnoDao.modificaContacto(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int eliminaContacto(object obj)
        {
            int i = oAlumnoDao.eliminaContacto(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
        public int eliminaActividad(object obj)
        {
            int i = oAlumnoDao.eliminaActividad(obj);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
