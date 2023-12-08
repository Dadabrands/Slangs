using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Slangs.Repositories; 
using Slangs.Entities;
using Slangs.DTOs;
using Slangs;
namespace Slangs.Controllers
{
    [ApiController]
    [Route("slangs")]
    public class SlangController : ControllerBase
    {
        private readonly IInmemoryRepo repo;
        public SlangController(IInmemoryRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IEnumerable<SlangsDto> GetSlangs()
        {
            var slangs = repo.GetSlangs().Select(slang => slang.AsDto());
            return slangs;
        }

        // Get slangs/id
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<SlangsDto>> GetSlang(Guid id)
        {
           var slang = repo.GetSlang(id).Select(slang => slang.AsDto());
           if(slang is null)
           {
            return NotFound();
           }
           return Ok(slang);
        }
    }
}