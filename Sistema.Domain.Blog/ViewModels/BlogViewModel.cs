using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Domain.Entities.ViewModels
{
    
    public class BlogViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "T�tulo � obrigat�rio!")]
        [MaxLength(100, ErrorMessage = "Limite do campo � 100 caracteres.")]
        public string Tilulo { get; set; }

        [Required(ErrorMessage = "Resumo � obrigat�rio!")]
        [MaxLength(300)]
        public string Resumo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Url { get; set; }

        [MaxLength(60)]
        public string Autor { get; set; }

        [Required]
        public string Captcha { get; set; }
    }
}
