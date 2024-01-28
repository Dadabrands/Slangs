using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slangs.Entities;
namespace Slangs.DTOs
{
    public class UserDto
    {
    public Guid Id{get; init;}
    public required string UserName { get; set; }
    public string? Input { get; set; }
    public string? FavSlang {get; set;}
    public Slang? UserInput{get; set;}
    }
}