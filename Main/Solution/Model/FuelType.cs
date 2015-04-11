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

        private Decimal heatingValueDec { get; set; }

        [NotMapped]
        public double HeatingValue
        {
            get { return (double)heatingValueDec; }
            set { heatingValueDec = (decimal)value; }
        }

        private Decimal co2EmissionFactorDec { get; set; }

        [NotMapped]
        public double CO2EmissionFactor
        {
            get { return (double)co2EmissionFactorDec; }
            set { co2EmissionFactorDec = (decimal)value; }
        }

        private Decimal errorMarginDec { get; set; }

        [NotMapped]
        public double ErrorMargin
        {
            get { return (double)errorMarginDec; }
            set { errorMarginDec = (decimal)value; }
        }
    }
}
