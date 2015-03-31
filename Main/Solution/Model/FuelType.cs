using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("FuelType")]
    public class FuelType : BaseEntity
    {
        [Column]
        public string Description { get; set; }

        [Column]
        public double HeatingValue { get; set; }

        [Column]
        public double CO2EmissionFactor { get; set; }

        [Column]
        public double ErrorMargin { get; set; }
    }
}
