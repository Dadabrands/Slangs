using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slangs.Entities;

namespace Slangs.Repositories;

    public class InMemoryRepo
    {
        private readonly List<Slang> slangs = new()
        {
            new Slang()
            {
                Id = Guid.NewGuid(),
                SlangName = "Omo",
                Meaning = "An exclamation for a particular reason, be it good or bad",
                Usage = "Omo see that fine babe \n Omo, God dey create ...",
                Origin = "Yoruba",
                UploadDate = DateTimeOffset.UtcNow
            },
            new Slang()
            {
                Id = Guid.NewGuid(),
                SlangName = "Muzz",
                Meaning = "A feeling of excitement because of an action that a person takes or because of a particular situation",
                Usage = "This guy dey muzz me gan \n Omo, everything just dey muzz me die",
                Origin = "English",
                UploadDate = DateTimeOffset.UtcNow

            },
            new Slang()
            {
                Id = Guid.NewGuid(),
                SlangName = "Rizz",
                Meaning = "An action by an human being that warrants confidence or charistma",
                Usage = "This guy has too much rizz \n Rizz me up",
                Origin = "English",
                UploadDate = DateTimeOffset.UtcNow

            },
            new Slang()
            {
                Id = Guid.NewGuid(),
                SlangName = "Dey Play",
                Meaning = "This means that you are joking with yourself or you're kidding yourself",
                Usage = "Just dey play",
                Origin = "Pidgin",
                UploadDate = DateTimeOffset.UtcNow
            }
        };
        public IEnumerable<Slang> GetSlangs()
        {
            return slangs;
        }
        public IEnumerable<Slang> GetSlang(Guid id)
        {
            var slang = slangs.Where(slang => slang.Id == id);
            return slang;
        } 
    //     public bool UpdateSlang(Guid id, string slangName)
    //     {
    //         if(slangs.Find(slang => slang.Id == id ) is NotNull)
    //         {
    //             if(slangs.Contains(slangName))
    //             {
    //                 slang.SlangName = slangName;
    //             }
    //         }

    //         return true;
    //     }
    //     public bool RemoveSlang(Guid id)
    //     {
    //         if (slangs.Contains(slang => slang.id == Id))
    //         {
    //             slangs.Remove(slang => slang.id == Id);
    //         }
    //         return true;
    //     }
    // }