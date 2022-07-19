using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace calculadora_api.Services
{
    public static class HashService
    {
        public static string Hash(string password)
        {
            //var hash = System.Security.Cryptography.SHA512.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
            var hash = System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
            var stringHashPassword = string.Join(string.Empty, hash.Select(i => i.ToString("X2")));

            return stringHashPassword;
        }
    }
}