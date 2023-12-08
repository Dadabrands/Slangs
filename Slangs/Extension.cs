using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slangs.DTOs;
using Slangs.Entities;

namespace Slangs;
    public static class Extension
    {
        public static SlangsDto AsDto(this Slang slang)
        {
            return new SlangsDto()
            {
                Id = slang.Id,
                SlangName = slang.SlangName,
                Usage = slang.Usage,
                Meaning = slang.Meaning,
                Origin = slang.Origin,
                UploadDate = slang.UploadDate
            };
        }
    }