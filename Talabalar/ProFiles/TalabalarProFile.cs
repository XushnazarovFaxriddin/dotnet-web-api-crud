using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabalar.Dtos;
using Talabalar.Models;

namespace Talabalar.ProFiles
{
    public class TalabalarProFile : Profile
    {
        public TalabalarProFile()
        {
            CreateMap<TalabaCreatedDto, Talaba>();

            CreateMap<Talaba, TalabaReadDto>();

            CreateMap<TalabaUpdateDto, Talaba>();
        }
    }
}
