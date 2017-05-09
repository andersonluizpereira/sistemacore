using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities.ManageBlog
{
    public class Blog
    {
        public int ID { get; set; }

        public string Tilulo { get; set; }

        public string Resumo { get; set; }

        public string Url { get; set; }

        public string Autor { get; set; }
    }
}
