using AutoMapper;
using SparkPlug.SparkPlugDao.Dto;
using SparkPlugDao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.MappingProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<SparkPlugDto, SparkPlugFeedback>();

        }
    }
}
