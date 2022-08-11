using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG.ApiNetCore6.Application.DTOs.Validations
{
    public class PessoaDTOValidator: AbstractValidator<PessoaDTO>
    {
        public PessoaDTOValidator()
        {
            RuleFor(x => x.Nome)
              .NotNull()
              .NotEmpty()
              .WithMessage("Nome deve ser informado");

            RuleFor(X => X.Celular)
                .NotNull()
                .NotEmpty()
                .WithMessage("Celular deve ser informado");


        }
    }
}
