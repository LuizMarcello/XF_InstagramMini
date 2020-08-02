using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF_InstagramMini.Models;

namespace XF_InstagramMini.Service
{
    public class UserService
    {
        private List<User> _user = new List<User>
        {
            new User
            {
               Id = 1,
               Name = "LuizMarcello",
               Description = "Meu nome é LuizMarcello"
            },

            new User
            {
                Id = 2,
                Name="NataliaRenata",
                Description = "Meu nome é Natalia Renata"
            },

            new User
            {
                Id = 3,
                Name = "ValeriaMiranda",
                Description = "Meu nome é Valéria Miranda"
            },

            new User
            {
                Id = 4,
                Name = "ThiagoJosé",
                Description = "Meu nome é Thiago José"
            },

            new User
            {
                Id = 5,
                Name = "GabrielIsaac",
                Description = "Meu nome é Gabriel Isaac"
            }
        };

        public IEnumerable<User> GetUsers()
        {
            return _user;
        }

        public User GetUserId(int searchId)
        {
            return _user.Single(u => u.Id == searchId);
        }
    }
}

            

