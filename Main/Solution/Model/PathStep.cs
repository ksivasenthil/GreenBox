using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PathStep")]
    public class PathStep : BaseEntity
    {
        [Column("TripLegId")]
        public Guid PathLegId { get; set; }

        [Column]
        public double FromLongitude { get; set; }

        [Column]
        public double FromLatitude { get; set; }

        [Column]
        public double ToLongitude { get; set; }

        [Column]
        public double ToLatitude { get; set; }

        [Column]
        public string PolylinePoints { get; set; }

        [Column]
        public string HtmlInstructions { get; set; }

        [Column]
        public TimeSpan Duration { get; set; }

        [Column]
        public double Distance { get; set; }

        public virtual PathLeg PathLeg { get; set; }
    }
}
