using LG.ApiNetCore6.Domain.Entities;
using LG.ApiNetCore6.Domain.Repositories;
using LG.ApiNetCore6.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _db;
        public ProdutoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Produto> CreateAsync(Produto produto)
        {
            _db.Add(produto);
            await _db.SaveChangesAsync();
            return produto;

        }

        public async Task DeleteAsync(Produto produto)
        {
            _db.Remove(produto);
            await _db.SaveChangesAsync();
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _db.Produto.FirstOrDefaultAsync(x => x.Id == id);
        }

       public async Task<ICollection<Produto>> GetProdutoAsync()
        {
            return await _db.Produto.ToListAsync();
        }

        public async Task<Produto> UpdateAsync(Produto produto)
        {
            _db.Update(produto);
            await _db.SaveChangesAsync();
            return produto;
        }
    }
}
