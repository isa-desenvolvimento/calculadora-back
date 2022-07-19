// using AutoMapper;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
// using Template.Application.Interfaces;
using calculadora_api.Models;
// using Template.Auth.Services;
// using Template.Domain.Entities;
// using Template.Domain.Interfaces;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
using calculadora_api.Repositories;

namespace Template.Application.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

/*
        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                throw new Exception("Email/Password are required.");

            user.Password = EncryptPassword(user.Password);

            User _user = _userRepository.VerifyUser(user.Username, user.Password);
            if (_user == null)
                throw new Exception("User not found");

            return new UserAuthenticateResponseViewModel(mapper.Map<UserViewModel>(_user), TokenService.GenerateToken(_user));
        }
*/

        private string EncryptPassword(string password)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();

            byte[] encryptedPassword = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                stringBuilder.Append(caracter.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}