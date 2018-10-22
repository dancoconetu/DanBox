using BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    interface IUserRepository
    {
        Guid CreateUser(string name);
        bool DeleteUser(Guid guid);
        bool UpdateUser(Guid id,string name);
        User GetUser(Guid id);
        IEnumerable<User> GetUsers();
    }
}
