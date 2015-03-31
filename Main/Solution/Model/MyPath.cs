using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("MyPath")]
    public class MyPath : BaseEntity
    {
        [Column]
        public string Description { get; set; }

        [Column]
        public string FromLocation { get; set; }

        [Column]
        public double FromLatitude { get; set; }

        [Column]
        public double FromLongitude { get; set; }

        [Column]
        public string ToLocation { get; set; }

        [Column]
        public double ToLatitude { get; set; }

        [Column]
        public double ToLongitude { get; set; }

        [Column]
        public decimal TotalDistance { get; set; }


    }
}
