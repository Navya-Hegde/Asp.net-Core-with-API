using SampleWeb.Model;
using SampleWeb.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWeb.Service
{
    public class UserService : IUserService
    {
        public List<User> userList;
        public UserService()
        {
            userList = new List<User>();
            userList.Add(new User
            {
                Id = 1,
                Name = "Navya",
                Email = "navya.hegde@gmail.com",
                Country = "India"
            });
            userList.Add(new User
            {
                Id = 2,
                Name = "Kirana",
                Email = "kiran@gmail.com",
                Country = "United Kingdom"
            });
        }
        public bool AddUser(User user)
        {
            userList.Add(new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Country = user.Country
            });
            return true;
        }

        public List<User> GetAllUser()
        {
            return userList;
        }

        public User GetUserById(int id)
        {
            var selectedUser = userList.FirstOrDefault<User>(x => x.Id == id);
            return selectedUser;
        }
    }
}
