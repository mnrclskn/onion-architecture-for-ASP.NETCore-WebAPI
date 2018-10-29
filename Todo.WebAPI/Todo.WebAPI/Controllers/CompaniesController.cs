using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Business.Abstract;
using Todo.DataAccess.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : Controller
    {
        
        private ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            var values = _companyService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult Add([FromBody]Company company)
        {
            _companyService.Add(company);
            return Ok(company);
        }
    }
}
