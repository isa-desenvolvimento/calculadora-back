using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using calculadora_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using calculadora_api.Services;
using System;
using System.Linq;

namespace calculadora_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        //GET:      api/users
        [HttpGet]
        // [Authorize(Roles = "admin")]
        public ActionResult<IEnumerable<User>> GetUserItems()
        {
            return _context.User;
        }

        //GET:      api/users/n
        [HttpGet("{id}")]
        public ActionResult<User> GetUserItem(int id)
        {
            var userItem = _context.User.Find(id);

            if (userItem == null)
            {
                return NotFound();
            }

            return userItem;
        }

        //POST:     api/users
        [HttpPost]
        public ActionResult<User> PostUserItem(User user)
        {
            user.Password = HashService.Hash(user.Password);

            _context.User.Add(user);
            _context.SaveChanges();

            return CreatedAtAction("GetUserItem", new User { Id = user.Id }, user);
        }

        //PUT:      api/users/n
        [HttpPut("{id}")]
        public ActionResult PutUserItem(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //DELETE:   api/users/n
        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUserItem(int id)
        {
            var userItem = _context.User.Find(id);

            if (userItem == null)
            {
                return NotFound();
            }

            _context.User.Remove(userItem);
            _context.SaveChanges();

            return userItem;
        }
    }
}