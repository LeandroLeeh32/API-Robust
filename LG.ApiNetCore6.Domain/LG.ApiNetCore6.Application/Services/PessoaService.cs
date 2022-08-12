using AutoMapper;
using LG.ApiNetCore6.Application.DTOs;
using LG.ApiNetCore6.Application.DTOs.Validations;
using LG.ApiNetCore6.Application.Services.Interface;
using LG.ApiNetCore6.Domain.Entities;
using LG.ApiNetCore6.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;
        public PessoaService(IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;

        }

        public async Task<ResultService<PessoaDTO>> CreateAsync(PessoaDTO pessoaDTO)
        {
            if (pessoaDTO == null)
                return ResultService.Fail<PessoaDTO>("Objeto deve ser informado");

            var result = new PessoaDTOValidator().Validate(pessoaDTO);
            if (!result.IsValid)
                return ResultService.RequestError<PessoaDTO>("Problema na validação", result);

            var pessoa = _mapper.Map<Pessoa>(pessoaDTO);
            var data = await _pessoaRepository.CreateAsync(pessoa);
            return ResultService.Sucess<PessoaDTO>(_mapper.Map<PessoaDTO>(data));



            
        }
    }
}
