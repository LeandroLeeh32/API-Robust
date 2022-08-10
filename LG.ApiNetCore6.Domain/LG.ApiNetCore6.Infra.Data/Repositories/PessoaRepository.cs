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
    public class PessoaRepository : IPessoaRepository
    {
        private readonly ApplicationDbContext _db;

        public PessoaRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Pessoa> GetByIdAsync(int id)
        {
            return await _db.Pessoa.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        public async Task<ICollection<Pessoa>> GetPessoaAsync()
        {
            return await _db.Pessoa.ToListAsync();
        }
        public async Task<Pessoa> CreateAsync(Pessoa pessoa)
        {
            _db.Add(pessoa);
            await _db.SaveChangesAsync();
            return pessoa;
        }
        public async Task<Pessoa> UpdateAsync(Pessoa pessoa)
        {
            _db.Update(pessoa);
            await  _db.SaveChangesAsync();
            return pessoa;

        }
        public async Task DeleteAsync(Pessoa pessoa)
        {
            _db.Remove(pessoa);
            await _db.SaveChangesAsync();

        }


    }
}
