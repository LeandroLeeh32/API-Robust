using LG.ApiNetCore6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Repositories
{
    public interface IPessoaRepository
    {
        Task<Pessoa> GetByIdAsync(int id);
        Task<ICollection<Pessoa>> GetPessoaAsync();
        Task<Pessoa> CreateAsync(Pessoa pessoa);
        Task<Pessoa> UpdateAsync(Pessoa pessoa);
        Task DeleteAsync(Pessoa pessoa);
    }
}
