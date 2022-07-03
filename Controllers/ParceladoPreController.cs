using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using calculadora_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace calculadora_api.Controllers
{
    [Route("api/parcelado-pre")]
    [ApiController]
    public class ParceladoPreController : ControllerBase
    {
        private readonly UserContext _context;

        public ParceladoPreController(UserContext context)
        {
            _context = context;
        }

        //GET:      api/users
        [HttpGet]
        // [Authorize(Roles = "admin")]
        public ActionResult<IEnumerable<ParceladoPre>> GetParceladoPreItems()
        {
            return _context.ParceladoPre;
        }

        //GET:      api/users/n
        [HttpGet("{id}")]
        public ActionResult<ParceladoPre> ParceladoPreItem(int id)
        {
            var parceladoPreItem = _context.ParceladoPre.Find(id);

            if (parceladoPreItem == null)
            {
                return NotFound();
            }

            return parceladoPreItem;
        }

        //POST:     api/users
        [HttpPost]
        public ActionResult PostParceladoPreItem(List<ParceladoPre> parceladoPreList)
        {
            foreach (var parceladoPre in parceladoPreList)
            {
                _context.ParceladoPre.Add(parceladoPre);
                _context.SaveChanges();
            }
            return NoContent();
        }

        //PUT:      api/users/n
        [HttpPut]
        public ActionResult PutParceladoPreItem(List<ParceladoPre> parceladoPreList)
        {
            foreach (var parceladoPre in parceladoPreList)
            {
                _context.Entry(parceladoPre).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return NoContent();
        }

        //DELETE:   api/users/n
        [HttpDelete("{id}")]
        public ActionResult<ParceladoPre> DeleteParceladoPreItem(int id)
        {
            var parceladoPreItem = _context.ParceladoPre.Find(id);

            if (parceladoPreItem == null)
            {
                return NotFound();
            }

            _context.ParceladoPre.Remove(parceladoPreItem);
            _context.SaveChanges();

            return parceladoPreItem;
        }
    }
}