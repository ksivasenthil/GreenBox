using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("TrackSegment")]
    public class TrackSegment : BaseEntity
    {
        [Column("TrackId")]
        public Guid MyTrackId { get; set; }

        public virtual MyTrack MyTrack { get; set; }
    }
}
