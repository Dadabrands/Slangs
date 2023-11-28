using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using namespace Slangs_API.Entities

namespace Slangs_API.Repositories
{
    public class InMemoryRepo
    {
        private readonly List<slang> slangs = new()
        {
            new slang()
            {
                Id = Guid.NewGuid(),
                slang = "Omo",
                Meaning = "An exclamation for a particular reason, be it good or bad",
                Usage = "Omo see that fine babe \n Omo, God dey create ...",
                Origin = "Yoruba"
                UploadDate = DateTimeOffset.UtcNOW
            }
            new slang()
            {
                Id = Guid.NewGuid(),
                slang = "Muzz",
                Meaning = "A feeling of excitement because of an action that a person takes or because of a particular situation",
                Usage = "This guy dey muzz me gan \n Omo, everything just dey muzz me die",
                Origin = "English"
                UploadDate = DateTimeOffset.UtcNOW
            }
            new slang()
            {
                Id = Guid.NewGuid(),
                slang = "Rizz",
                Meaning = "An action by an human being that warrants confidence or charistma",
                Usage = "This guy has too much rizz \n Rizz me up",
                Origin = "English",
                UploadDate = DateTimeOffset.UtcNOW

            }
        }
        public IEnumerable<slang> slang()
        {
            return slangs;
        }
        public slang GetSlang(Guid id)
        {
            return slangs.Where(slang => slang.Id == id).SingleOrDefault();
        }
    }
}