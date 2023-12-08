using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slangs.Entities;

namespace Slangs.Repositories;
public interface IInmemoryRepo
{
    IEnumerable<Slang> GetSlangs();
    IEnumerable<Slang> GetSlang(Guid id);
}