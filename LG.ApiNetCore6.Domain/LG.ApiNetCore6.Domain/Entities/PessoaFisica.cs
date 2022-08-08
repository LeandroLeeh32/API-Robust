using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Entities
{
    public sealed class PessoaFisica
    {
        public string CNPJ { get; private set; }
    


        public PessoaFisica(string CNPJ)
        {
            Validation(CNPJ);
        }

        private void Validation(string cnpj)
        {
            Domain.Validations.DomainValidationException.When(string.IsNullOrEmpty(cnpj), "Nome deve ser informado!");
            CNPJ = cnpj;
        }
    }
}
