using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TransportMode")]
    public class TransportMode : BaseEntity
    {
        [Column]
        public string Description { get; set; }
    }
}
