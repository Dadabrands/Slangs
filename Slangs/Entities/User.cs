using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slangs.Entities
{
    public class User
    {
    public Guid Id{get; init;}
    public required string UserName { get; set; }
    public string? Input { get; set; }
    public string? FavSlang {get; set;}
    public Slang? UserInput{get; set;}
    }
}