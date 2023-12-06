using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slangs.Repositories; 
using Slangs.Entities;

namespace Slangs.Controllers
{
    [ApiController]
    [Route("slangs")]
    public class SlangController : ControllerBase
    {
        private readonly InMemoryRepo repo;
        public SlangController()
        {
            repo = new InMemoryRepo();
        }

        [HttpGet]
        public IEnumerable<Slang> GetSlangs()
        {
            var slang = repo.GetSlangs();
            return slang;
        }
    }
}