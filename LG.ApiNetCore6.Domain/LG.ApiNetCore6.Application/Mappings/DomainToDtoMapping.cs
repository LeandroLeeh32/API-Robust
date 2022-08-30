using AutoMapper;
using LG.ApiNetCore6.Application.DTOs;
using LG.ApiNetCore6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.Mappings
{
    public class DomainToDtoMapping:Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<Pessoa, PessoaDTO>();
        }
    }
}
