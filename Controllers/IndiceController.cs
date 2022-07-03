using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using calculadora_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System;

namespace calculadora_api.Controllers
{
    [Route("api/indices")]
    [ApiController]
    public class IndiceController : ControllerBase
    {
        private readonly UserContext _context;

        public IndiceController(UserContext context)
        {
            _context = context;
        }

        //GET:      api/indices/indice
        [HttpGet]
        // [Authorize(Roles = "admin")]
        public ActionResult<IEnumerable<Indice>> GetIndiceItemsParameter([FromQuery] string indice, [FromQuery] int pageSize = 10, [FromQuery] int pageNumber = 0, [FromQuery] int draw = 1, [FromQuery] bool getAll = false)
        {
            IQueryable<Indice> _indiceListByParameter = _context.Indice.Where(item => item.indice == indice).OrderByDescending(x => x.data);
            int recordsTotal = _indiceListByParameter.Count();

            if (getAll)
            {
                return _indiceListByParameter.ToList();
            }
            else
            {
                var data = _indiceListByParameter
                       .Skip(pageSize * pageNumber)
                       .Take(pageSize)
                       .ToList();

                return new ObjectResult(new { draw, recordsTotal, data });
            }

        }

        //GET:      api/indices/indice
        [HttpGet("byDate")]
        // [Authorize(Roles = "admin")]
        public ActionResult<Indice> GetIndiceItemsByDate([FromQuery] string indice, [FromQuery] DateTime data)
        {
            return _context.Indice
                        .Where(item => item.indice == indice)
                        .Where(item => item.data == data)
                        .OrderByDescending(x => x.data)
                        .Single();
        }


        //GET:      api/indices/id
        [HttpGet("{id}")]
        public ActionResult<Indice> IndiceItem(int id)
        {
            var indiceItem = _context.Indice.Find(id);

            if (indiceItem == null)
            {
                return NotFound();
            }

            return indiceItem;
        }

        //POST:     api/indices
        [HttpPost]
        public ActionResult PostIndiceItem(List<Indice> indiceList)
        {
            foreach (var indice in indiceList)
            {
                _context.Indice.Add(indice);
                _context.SaveChanges();
            }
            return NoContent();
        }

        //PUT:      api/indices/indiceList
        [HttpPut]
        public ActionResult PutIndiceItem(List<Indice> indiceList)
        {
            foreach (var indice in indiceList)
            {
                _context.Entry(indice).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return NoContent();
        }

        //DELETE:   api/indices/id
        [HttpDelete("{id}")]
        public ActionResult<Indice> DeleteIndiceItem(int id)
        {
            var indiceItem = _context.Indice.Find(id);

            if (indiceItem == null)
            {
                return NotFound();
            }

            _context.Indice.Remove(indiceItem);
            _context.SaveChanges();

            return indiceItem;
        }
    }
}