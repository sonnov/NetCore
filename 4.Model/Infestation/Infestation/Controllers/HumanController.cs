using Infestation.Models;
using Infestation.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infestation.Controllers
{
    public class HumanController : Controller
    {
        //private IHumanRepository _repository { get; set; }
        private InfestationDbContext _dbContext { get; set; }

        public HumanController(/*IHumanRepository repository*/ InfestationDbContext dbContext)
        {
            //_repository = repository;
            _dbContext = dbContext;
        }

        // GET: human/
        public string Index()
        {
            //return _repository.GetAllHumans();
            return _dbContext.Humans.FirstOrDefault().Country.Name;
        }

        // GET: human/{Id}
        //public IEnumerable<Human> Index(int Id)
        //{
        //    //return _repository.GetAllHumans();
        //    throw new NotImplementedException(); 
        //}
    }
}
