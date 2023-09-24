using RAAMEN.Handler;
using RAAMEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN.Controller
{
    public class UserController
    {
        public static List<User> getAllStaff()
        {
            return UserHandler.getAllStaff();
        }
        public static List<User> getAllCustomer()
        {
            return UserHandler.getAllCustomer();
        }
        public static User getUserBasedOnId(int id)
        {
            return UserHandler.getUserBasedOnId(id);
        }
        public static User loginAccount(String username, String password)
        {
            return UserHandler.getUserByUsername(username, password);
        }
        public static bool usernameValidation(String s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }
        public static bool emailValidation(String text)
        {
            int length = text.Length;
            if (length < 5)
            {
                return false;
            }
            else if (text[length - 4] == '.' && text[length - 3] == 'c' && text[length - 2] == 'o' && text[length - 1] == 'm')
            {
                return true;
            }
            return false;
        }
        public static bool passwordValidation(int id, String password)
        {
            User user = UserHandler.getUserBasedOnId(id);
            if (user.Password.Equals(password)){
                return true;
            }
            return false;
        }
        public static String insertUser(int roleId, String username, String email, String gender, String password, String confirmPassword)
        {
            if (username.Equals("") || email.Equals("") || password.Equals("") || confirmPassword.Equals(""))
            {
                return "No input";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                return "Username length must be between 5 and 15 character";
            }
            else if (usernameValidation(username) == false)
            {
                return "Username must contain alphabet with space only";
            }
            else if (emailValidation(email) == false)
            {
                return "Email Must ends with ‘.com’";
            }
            else if (!gender.Equals("Male") && !gender.Equals("Female"))
            {
                return "Gender Must be chosen";
            }
            else if (!password.Equals(confirmPassword))
            {
                return "Password and confirm password must be same";
            }
            else
            {
                String text = UserHandler.insertUser(roleId, username, email, gender, password);
                return text;
            }
        }
        public static String updateUser(int id, String username, String email, String gender, String password)
        {
            if (username.Equals("") || email.Equals("") || password.Equals(""))
            {
                return "No input";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                return "Username length must be between 5 and 15 character";
            }
            else if (usernameValidation(username) == false)
            {
                return "Username must contain alphabet with space only";
            }
            else if (emailValidation(email) == false)
            {
                return "Email Must ends with ‘.com’";
            }
            else if (!gender.Equals("Male") && !gender.Equals("Female"))
            {
                return "Gender Must be chosen";
            }
            else if (passwordValidation(id, password) == false)
            {
                return "Password incorrect";
            }
            else
            {
                return UserHandler.updateUser(id, username, email, gender);
            }
        }
    }
}
