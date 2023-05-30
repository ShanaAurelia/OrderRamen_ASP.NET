using PSD_LAB_PROJECT.Factory;
using PSD_LAB_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LAB_PROJECT.Repository
{
    public class UserRepository
    {
        public static User CreateUserRepo(string username, string email, string gender, string password)
        {
            DatabaseEntities db = new DatabaseEntities();
            User newUser = UserFactory.CreateUserFactory(username, email, gender, password);
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser;
        }

        public static User getUserLogin(string username)
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.Users.Where((x) => x.Username.Equals(username)).FirstOrDefault();
        }

        public static List<UserOutput> dataForStaff()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<UserOutput> userData = (from users in db.Users 
                        join roles in db.Roles on users.RoleId equals roles.Id
                        where roles.name.Equals("Customer")
                    select new UserOutput { 
                        Role = roles.name,
                        Name = users.Username,
                        Gender = users.Gender
                    }).ToList();
            return userData;
        }

        public static List<UserOutput> dataForAdmin()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<UserOutput> userData = (from users in db.Users
                                         join roles in db.Roles on users.RoleId equals roles.Id
                                         where !roles.name.Equals("Admin")
                                         select new UserOutput
                                         {
                                             Role = roles.name,
                                             Name = users.Username,
                                             Gender = users.Gender
                                         }).ToList();
            return userData;
        }
    }
}