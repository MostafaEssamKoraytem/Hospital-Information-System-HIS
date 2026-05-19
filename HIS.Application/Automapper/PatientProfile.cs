using AutoMapper;
using HIS.Application.DTO;
using HIS.Application.DTO.Patient;
using HIS.Domain.Aggregates.PatientAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Automapper
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Patient, UpdatePatientRequest>().ReverseMap();
            CreateMap<CreatePatientRequest, Patient>().ReverseMap();

        }
    }
}
