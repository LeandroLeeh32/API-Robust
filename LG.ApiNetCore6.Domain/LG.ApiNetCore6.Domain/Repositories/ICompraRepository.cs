using LG.ApiNetCore6.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Repositories
{
    public interface ICompraRepository
    {

        Task<Compra> CreateAsync(Compra compra);
        Task DeleteAsync(Compra compra);
        Task<Compra> UpdateAsync(Compra compra);
        Task<ICollection<Compra>> GetAllAsync();
        Task<Compra> GetByIdAsync(int id);
        Task<ICollection<Compra>> GetAllByPessoaIdAsync(int produtoId);
        Task<ICollection<Compra>> GetByProdutoIdAsync(int produtoId);
 

    }
}
