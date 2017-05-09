using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities.ViewModels
{
    public class CarrinhoComprasViewModel
    {
        public List<Produto> Produtos { get; set; }

        public decimal Total { get; set; }

        public string Mensagem { get; set; }
    }
}
