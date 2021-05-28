using FirstWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Employes> Get()
        {
            //CRUD
            using (var _context = new EmployeeDBcontext())
            {
                //Insert

                Employes employes = new Employes();
                employes.empname = "smith";
                employes.empemail = "smith@gmail.com";
                employes.empaddress = "US";
                employes.empdesignation = "IT";
                employes.empsalary = 6000;
                _context.Employes.Add(employes);
                _context.SaveChanges();


                //Update

                //Employes employes = _context.Employes.FirstOrDefault();
                //employes.empname = "adam";
                //_context.SaveChanges();

                //Read

                //return _context.Employes.ToList();

                //delete
                //_context.Employes.Remove(employes);
                //_context.SaveChanges();

            }
            return new List<Employes>();
        }


    }
}