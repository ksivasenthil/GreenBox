using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("MyTrack")]
    public class MyTrack : BaseEntity
    {
        [Column]
        public string Description { get; set; }

        [Column]
        public DateTime MyTripOn { get; set; }

        [Column("PathID")]
        public Guid MyPathID { get; set; }

        [Column]
        public Guid VehicleTypeID { get; set; }

        [Column]
        public double FuelConsumed { get; set; }

        [Column]
        public double VehicleWeight { get; set; }

        public virtual MyPath MyPath { get; set; }

        public virtual VehicleType VehicleType { get; set; }
    }
}
