using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities
{
    public class Produto
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
