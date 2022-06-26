using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Domain.Entities
{
    internal sealed class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public PersonLegal  PessoaLegal { get; set; }
        public PersonNatural PersonNatural { get; set; }

        public Person(string name, string phone)
        {
            Validation(name, phone);
        }

        private void Validation(string name, string cellPhone)
        {
            Domain.Validations.DomainValidationException.When(string.IsNullOrEmpty(name),"Nome deve ser informado!");
            Domain.Validations.DomainValidationException.When(string.IsNullOrEmpty(CellPhone), "Celular deve ser informado!");

            Name = name;
            CellPhone = cellPhone;
        }

    }
}
