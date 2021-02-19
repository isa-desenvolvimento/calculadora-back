using System;
using System.Collections.Generic;
using System.Linq;
using calculadora_api.Models;
using calculadora_api.Services;

namespace calculadora_api.Repositories
{
    public static class UserRepository
    {
        public static User VerifyUser(string username, string password)
        {
            var users = new List<User>();

            DateTime localDate = DateTime.Now;

            users.Add(new User { Id = 1, Username = "admin", Password = "admin", Profile = "admin", Status = true, CreatedDate = localDate });
            users.Add(new User { Id = 2, Username = "editor", Password = "editor", Profile = "employee", Status = true, CreatedDate = localDate });
            users.Add(new User { Id = 3, Username = "consult", Password = "consult", Profile = "consult", Status = true, CreatedDate = localDate });

            return users.Where(x =>
                 x.Username.ToLower() == username.ToLower() && HashService.Verify(x.Password, HashService.Hash(password))
            ).FirstOrDefault();
        }

        public static List<User> UserList()
        {
            var users = new List<User>();

            DateTime localDate = DateTime.Now;

            users.Add(new User { Id = 1, Username = "admin", Password = "admin", Profile = "admin", Status = true, CreatedDate = localDate });
            users.Add(new User { Id = 2, Username = "editor", Password = "editor", Profile = "employee", Status = true, CreatedDate = localDate });
            users.Add(new User { Id = 3, Username = "consult", Password = "consult", Profile = "consult", Status = true, CreatedDate = localDate });

            return users;
        }
    }
}