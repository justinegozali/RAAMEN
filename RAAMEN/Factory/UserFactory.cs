using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Factory
{
    public class UserFactory
    {
        public static User createUser(int roleId, String username, String email, String gender, String password)
        {
            User user = new User();
            user.RoleId = roleId;
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            return user;
        }
    }
}