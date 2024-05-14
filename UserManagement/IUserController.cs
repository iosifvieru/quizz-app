using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_ip
{
    public interface IUserController
    {
        bool addUser(User user);
        bool deleteUser(int id);
        bool updateUser(int id, User user);
        User getUser(int id);
    }
}
