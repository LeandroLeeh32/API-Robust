using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Entities
{
    public sealed class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Celular { get; private set; }
        public PessoaFisica PessoaFisica { get; private set; }
        public PessoaJuridica PessoaJuridica { get; private set; }
        public ICollection<Compra> Compra { get; set; }

        public Pessoa(string name, string phone)
        {
            Validation(name, phone);
            Compra = new List<Compra>();
        }

        private void Validation(string nome, string celular)
        {
            Validations.DomainValidationException.When(string.IsNullOrEmpty(nome), "Nome deve ser informado!");
            Validations.DomainValidationException.When(string.IsNullOrEmpty(celular), "Celular deve ser informado!");

            Nome = nome;
            Celular = celular;
        }

    }
}
