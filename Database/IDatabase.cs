using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    public interface IDatabase
    {
        DataTable ExecuteQuery(string query);
        int ExecuteNonQuery(string query);
    }
}
