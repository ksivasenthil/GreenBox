using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("VehicleType")]
    public class VehicleType : BaseEntity
    {
        [Column]
        public Guid TransportModeId { get; set; }

        [Column]
        public string Description { get; set; }

        public virtual TransportMode TransportMode { get; set; }
    }
}
