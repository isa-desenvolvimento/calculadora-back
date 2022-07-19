using System;
using System.Collections.Generic;
using System.Linq;
using calculadora_api.Models;
using calculadora_api.Services;

namespace calculadora_api.Repositories
{
    public class UserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User VerifyUser(string username, string password)
        {
            var passwordHash = HashService.Hash(password);

            return _context.User.Where(x => x.Username == username && x.Password == passwordHash).FirstOrDefault();
        }

        public List<User> UserList()
        {
            return _context.User.ToList();
        }
    }
}