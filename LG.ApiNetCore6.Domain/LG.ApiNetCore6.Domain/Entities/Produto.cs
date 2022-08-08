using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Entities
{
    public sealed class Produto
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public string Codigo { get; private set; }
        public decimal Preco { get; private set; }
        public ICollection<Compra> Compra { get; set; }


        public Produto(string descricao, string codigo, decimal preco)
        {
            Validacao(descricao, codigo, preco);
        }



        private void Validacao(string descricao, string codigo, decimal preco)
        {
            Domain.Validations.DomainValidationException.When(string.IsNullOrEmpty(descricao), "Descricao deve ser informado!");
            Domain.Validations.DomainValidationException.When(string.IsNullOrEmpty(codigo), "Código deve ser informado!");
            Domain.Validations.DomainValidationException.When((preco < 0), "Preço deve ser informado!");

            Descricao = descricao;
            Codigo = codigo;
            Preco = preco;
        }

    }
}
