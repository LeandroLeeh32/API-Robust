using LG.ApiNetCore6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.Services.Interface
{
    public interface IPessoaService
    {
        Task<ResultService<PessoaDTO>> CreateAsync(PessoaDTO pessoaDTO);
    }
}
