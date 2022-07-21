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
    [Route("api/pastas")]
    [ApiController]
    public class PastasController : ControllerBase
    {
        private readonly UserContext _context;

        public PastasController(UserContext context)
        {
            _context = context;
        }

        //GET:      api/pastas
        [HttpGet]
        // [Authorize(Roles = "admin")]
        public ActionResult<IEnumerable<Pastas>> GePastasItems()
        {
            var listAll =  _context.Pastas;
            
            if (listAll == null)
            {
                return NotFound();
            }

            return listAll;
        }
		}
       
}