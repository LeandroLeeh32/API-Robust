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
    public class CompraRepository : ICompraRepository
    {
        private readonly ApplicationDbContext _db;
        public CompraRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task DeleteAsync(Compra compra)
        {
            _db.Remove(compra);
            await _db.SaveChangesAsync();
        }
        public async Task<Compra> CreateAsync(Compra compra)
        {
            _db.Add(compra);
            await _db.SaveChangesAsync();
            return compra;
        }
        public async Task<Compra> UpdateAsync(Compra compra)
        {
            _db.Update(compra);
            await _db.SaveChangesAsync();
            return compra;
        }
        public async Task<ICollection<Compra>> GetAllAsync()
        {
            return await _db.Compra.ToListAsync();
        }
        public async Task<Compra> GetByIdAsync(int id)
        {
            return await _db.Compra.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<ICollection<Compra>> GetAllByPessoaIdAsync(int pessoaId)
        {
            return await _db.Compra
                .Include(x => x.Pessoa)
                .Include(x => x.Produto)
                .Where(x => x.ProdutoId == pessoaId).ToListAsync();
        }
        public async Task<ICollection<Compra>> GetByProdutoIdAsync(int produtoId)
        {
            return await _db.Compra
                .Include(x => x.Produto)
                .Include(x => x.Pessoa)
                .Where(x => x.ProdutoId == produtoId).ToListAsync();
        }
    }
}
