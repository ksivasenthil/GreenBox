using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("VehicleSubType")]
    public class VehicleSubType : BaseEntity
    {
        [Column]
        public Guid VehicleTypeId { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public Guid FuelTypeId { get; set; }

        [Column]
        public double Mileage { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        public virtual FuelType FuelType { get; set; }
    }
}
