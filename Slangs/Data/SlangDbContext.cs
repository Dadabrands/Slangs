using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Slangs.Entities;

namespace Slangs.Data
{
    public class SlangDbContext : DbContext
    {
        public SlangDbContext(DbContextOptions<SlangDbContext> options) : base(options)
        {

        }
        public DbSet<Slang> Slang{get; set;}

        public DbSet<User> User{get; set;}

        private readonly List<Slang> slangs = new();
        
        public IEnumerable<Slang> GetSlang(Guid id)
        {
            var slang = slangs.Where(slang => slang.Id == id);
            return slang;
        }

        public IEnumerable<Slang> GetSlangs()
        {
            return slangs;
        }

    }
}