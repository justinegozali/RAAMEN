using RAAMEN.Factory;
using RAAMEN.Model;
using RAAMEN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Handler
{
    public class UserHandler
    {
        public static List<User> getAllStaff()
        {
            return UserRepository.getAllStaff();
        }
        public static List<User> getAllCustomer()
        {
            return UserRepository.getAllCustomer();
        }
        public static User getUserBasedOnId(int id)
        {
            return UserRepository.getUserBasedOnId(id);
        }
        public static User getUserByUsername(String username, String password)
        {
            return UserRepository.getUserBasedOnUsername(username, password);
        }
        public static String insertUser(int roleId, String username, String email, String gender, String password)
        {
            User user = UserFactory.createUser(roleId, username, email, gender, password);
            return UserRepository.insertUser(user);
        }
        public static String updateUser(int id, String username, String email, String gender)
        {
            return UserRepository.updateUser(id, username, email, gender);
        }
    }
}