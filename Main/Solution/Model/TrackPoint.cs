using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TrackPoint")]
    public class TrackPoint : BaseEntity
    {
        [Column("SegmentId")]
        public Guid TrackSegmentId { get; set; }

        [Column]
        public double Latitude { get; set; }

        [Column]
        public double Longitude { get; set; }

        [Column]
        public double Elevation { get; set; }

        [Column]
        public DateTime TrackPointTime { get; set; }

        public virtual TrackSegment TrackSegment { get; set; }
    }
}
