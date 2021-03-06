﻿using FluentValidation;
using Minimundo.Domain.Entities;
using Minimundo.Infra.CrossCutting;

namespace Minimundo.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Email)
                .EmailAddress().WithMessage($"Email inválido.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Email'.")
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Email.")
                .MaximumLength(255).WithMessage($"{ValidatorConst.Maximo} Email é 255.");

            RuleFor(c => c.Senha)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Senha.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Senha'.")
                .Must(ValidatorConst.Senha).WithMessage("A senha deve conter no mínimo 8 caracteres, 1 letra minúscula, 1 letra maíuscula, 1 número e um caractere especial.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Senha é 100.");

            RuleFor(c => c.Nome)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Nome.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Nome'.")
                .MaximumLength(100).WithMessage($"{ValidatorConst.Maximo} Nome é 100.");

            RuleFor(c => c.CPF)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} CPF.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'CPF'.")
                .Must(ValidatorConst.CPF).WithMessage($"CPF inválido.");

            RuleFor(c => c.Sexo)
                .NotNull().WithMessage($"{ValidatorConst.Nulo} Sexo.")
                .NotEmpty().WithMessage($"{ValidatorConst.Vazio} 'Sexo'.")
                .Must(SexoTipo).WithMessage("Informe: Masculino, Feminino ou Outro.");
        }

        public static bool SexoTipo(char sexo)
        {
            return (sexo == 'M' || sexo == 'F' || sexo == 'O');
        }
    }
}