using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Domain.Core.Entity
{
    public interface IEntity<TKey>
           where TKey : struct
    {
        TKey Id { get; set; }
    }
}
