using System;
using System.Collections.Generic;
using System.Text;
using Shikiro.LearnThrift.Service.Interface.User;

namespace Shikiro.LearnThrift.Service.Implementation.User
{
    public class UserService : IUserService.Iface
    {
        public List<Interface.User.User> GetAll()
        {
            return new List<Interface.User.User>()
            {
                new Interface.User.User(){ Id = 1, Name = "John" },
                new Interface.User.User(){ Id = 2, Name = "Mike" }
            };
        }
    }
}
