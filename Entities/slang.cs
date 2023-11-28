using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slangs_API.Entities;

public record slang
{
    public Guid Id { get; init; }
    public required string slang{get; set;}
    public required string Meaning { get; set; }
    public required string Usage { get; set; }
    public required string Origin { get; set; }
    public DateTimeOffset UploadDate {get; set;}
}