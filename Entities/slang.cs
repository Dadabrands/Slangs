using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slangs_API.Entities;

public class Slang
{
    public Guid Id { get; init; }
    public string? SlangName{get; set;}
    public string? Meaning { get; set; }
    public string? Usage { get; set; }
    public string? Origin { get; set; }
    public required DateTimeOffset UploadDate {get; set;}
}

public class User
{
    public Guid Id{get; init;}
    public required string UserName { get; set; }
    public string? Input { get; set; }
    public string? FavSlang {get; set;}
}