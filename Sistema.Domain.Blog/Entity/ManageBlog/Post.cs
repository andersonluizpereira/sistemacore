using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Entities.ManageBlog
{
    public class Post
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public Blog Blog { get; set; }
    }
}
