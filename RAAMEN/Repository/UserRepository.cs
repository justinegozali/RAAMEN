using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Repository
{
    public class UserRepository
    {
        static RaamenDatabaseEntities1 db = new RaamenDatabaseEntities1();

        public static List<User> getAllUser()
        {
            return db.Users.ToList();
        }
        public static List<User> getAllStaff()
        {
            List<User> staff = (from dat in db.Users where dat.RoleId == 2 select dat).ToList();
            return staff;
        }
        public static List<User> getAllCustomer()
        {
            List<User> customer = (from dat in db.Users where dat.RoleId == 3 select dat).ToList();
            return customer;
        }
        public static User getUserBasedOnId(int id)
        {
            return db.Users.Find(id);
        }
        public static User getUserBasedOnUsername(String username, String password)
        {
            User user = (from dat in db.Users where dat.Username.Equals(username) && dat.Password.Equals(password) select dat).FirstOrDefault();
            return user;
        }
        public static String insertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return "Insert Success";
        }
        public static String updateUser(int id, String username, String email, String gender)
        {
            User user = getUserBasedOnId(id);
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            db.SaveChanges();
            return "Update Success";
        }
    }
}