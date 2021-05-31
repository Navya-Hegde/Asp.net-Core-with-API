using SampleWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWeb.Service.Interface
{
    public interface IUserService
    {
        bool AddUser(User user);
        User GetUserById(int id);
        List<User> GetAllUser();
    }
}
