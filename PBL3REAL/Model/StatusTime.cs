using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("status_time")]
    public partial class StatusTime
    {
        [Key]
        [Column("id_statim")]
        public int IdStatim { get; set; }
        [Column("statim_fromdate", TypeName = "date")]
        public DateTime StatimFromdate { get; set; }
        [Column("statim_todate", TypeName = "date")]
        public DateTime StatimTodate { get; set; }
        [Column("statim_idroom")]
        public int StatimIdroom { get; set; }
        [Column("statim_idstatus")]
        public int StatimIdstatus { get; set; }

        [ForeignKey(nameof(StatimIdroom))]
        [InverseProperty(nameof(Room.StatusTimes))]
        public virtual Room StatimIdroomNavigation { get; set; }
        [ForeignKey(nameof(StatimIdstatus))]
        [InverseProperty(nameof(Status.StatusTimes))]
        public virtual Status StatimIdstatusNavigation { get; set; }
    }
}
