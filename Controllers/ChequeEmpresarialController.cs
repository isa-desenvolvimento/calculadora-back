using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using calculadora_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;

namespace calculadora_api.Controllers
{
    [Route("api/cheque-empresarial")]
    [ApiController]
    public class ChequeEmpresarialController : ControllerBase
    {
        private readonly UserContext _context;

        public ChequeEmpresarialController(UserContext context)
        {
            Console.WriteLine("Entrei aqui");
            Console.WriteLine(context.ToString());
            _context = context;
        }

        //GET:      api/users
        [HttpGet]
        // [Authorize(Roles = "admin")]
        public ActionResult<IEnumerable<ChequeEmpresarial>> GetChequeEmpresarialItems()
        {
            var chequeempresarialAll =  _context.ChequeEmpresarial;
            
            if (chequeempresarialAll == null)
            {
                return NotFound();
            }

            return chequeempresarialAll;
        }

        //GET:      api/users/n
        [HttpGet("{id}")]
        public ActionResult<ChequeEmpresarial> ChequeEmpresarialItem(int id)
        {
            var chequeempresarialItem = _context.ChequeEmpresarial.Find(id);

            if (chequeempresarialItem == null)
            {
                return NotFound();
            }

            return chequeempresarialItem;
        }

        //POST:     api/users
        [HttpPost]
        public ActionResult PostChequeEmpresarialItem(List<ChequeEmpresarial> chequeEmpresarialList)
        {
            foreach (var chequeEmpresarial in chequeEmpresarialList)
            {
                _context.ChequeEmpresarial.Add(chequeEmpresarial);
                _context.SaveChanges();
            }
            return NoContent();
        }

        //PUT:      api/users/n
        [HttpPut]
        public ActionResult PutChequeEmpresarialItem(List<ChequeEmpresarial> chequeEmpresarialList)
        {
            foreach (var chequeEmpresarial in chequeEmpresarialList)
            {
                _context.Entry(chequeEmpresarial).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return NoContent();
        }

        //DELETE:   api/users/n
        [HttpDelete("{id}")]
        public ActionResult<ChequeEmpresarial> DeleteChequeEmpresarialItem(int id)
        {
            var chequeempresarialItem = _context.ChequeEmpresarial.Find(id);

            if (chequeempresarialItem == null)
            {
                return NotFound();
            }

            _context.ChequeEmpresarial.Remove(chequeempresarialItem);
            _context.SaveChanges();

            return chequeempresarialItem;
        }
    }
}