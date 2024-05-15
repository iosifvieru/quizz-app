using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    /*
        Interfata pentru persistenta datelor.

        Practic orice clasa care implementeaza aceasta interfata trebuie neaparat sa implementeze metodele
        indiferent de ce mod de stocare al datelor prefera (xml, json) sau ce SGBD (ex. mysql, mariabd, oracle, sqlite, mongodb).
        
     */

    public interface IDatabase
    {
        DataTable ExecuteQuery(string query);
        int ExecuteNonQuery(string query);
    }
}
