using PSD_LAB_PROJECT.Handler;
using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Controller
{
    public class UserController
    {
        public static string validateUserRegistry(string username, string email, string gender, string password, string cpassword)
        {
            User newUser = new User();

            // validasi
            if (username.Equals("") || email.Equals("") || gender.Equals("") || password.Equals(""))
            {
                return "Please fill all the required fields!";
            }
            if(username.Length > 15 && username.Length < 5)
            {
                return "Username length is between 5 to 15 characters!";
            }
            if(username.Contains(" "))
            {
                return "Username cannot contain spaces!";
            }
            if (!email.EndsWith(".com"))
            {
                return "Enter a valid email with .com at the end!";
            }
            if (gender.Equals(""))
            {
                return "Please select a gender!";
            }
            if (!(password.Equals(cpassword))){
                return "Password not the same with confirm password!";
            }
                UserHandler.createUserHandler(username, email, gender, password);
                return "success!";
        }

        public static string validateUserLogin(string username, string password)
        {
            User user = UserHandler.loginUserHandler(username);
            if (user.Equals(null))
            {
                return "Please fill all the required fields!";
            }
            if (user.Username.Equals("") || user.Username.Equals(""))
            {
                return "Please fill all the required fields!";
            }
            else if (user.Username.Equals(username) && user.Password.Equals(password))
            {
                return "success!";
            }
            else
            {
                return "Your username and password does not match our database!";
            }
        }

        public static string validateUserRole(string username)
        {
            User user = UserHandler.loginUserHandler(username);
            if(user.RoleId == 1)
            {
                return "Admin";
            }
            if(user.RoleId == 2)
            {
                return "Staff";
            }
            if(user.RoleId == 3)
            {
                return "Customer";
            }
            return "";
        }

        public static List<UserOutput> datasourceForStaff()
        {
            return UserHandler.getDataForStaff();
        }

       public static List<UserOutput> datasourceForAdmin()
        {
            return UserHandler.getDataForAdmin();
        }
    }
}