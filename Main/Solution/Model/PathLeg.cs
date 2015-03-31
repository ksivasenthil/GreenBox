using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PathLeg")]
    public class PathLeg : BaseEntity
    {
        [Column("PathId")]
        public Guid MyPathId { get; set; }

        [Column]
        public double FromLatitude { get; set; }

        [Column]
        public double FromLongitude { get; set; }

        [Column]
        public double ToLatitude { get; set; }

        [Column]
        public double ToLongitude { get; set; }

        [Column]
        public TimeSpan Duration { get; set; }

        [Column]
        public double Distance { get; set; }

        public virtual MyPath MyPath { get; set; }
    }
}
