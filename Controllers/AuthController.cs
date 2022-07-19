using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using calculadora_api.Models;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using calculadora_api.Services;
using calculadora_api.Repositories;

namespace calculadora_api.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly UserRepository _userRepository;

        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            var user = _userRepository.VerifyUser(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Password = null;

            return new
            {
                user = user,
                token = token
            };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("users")]
        [Authorize(Roles = "admin")]
        public List<User> Manager() => _userRepository.UserList();

    }
}