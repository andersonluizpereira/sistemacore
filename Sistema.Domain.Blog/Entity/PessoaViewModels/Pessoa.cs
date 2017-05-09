using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Domain.Entities.PessoaViewModels
{
    public class Pessoa
    {
        [Required]
        [BindNever]
        [MaxLength(10, ErrorMessage = "Maximo de 10 cacteres")]
        public string Nome { get; set; }

        [Required]
        [BindRequired]
        [MaxLength(30)]
        public string UltimoNome { get; set; }

        [Required]
        [BindRequired]
        public DateTime DataNascimento { get; set; }

        public bool IsEstudante;

        
    }
}
