using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public abstract class BaseEntity
    {
        [Column]
        public Guid Id { get; set; }
    }
}
