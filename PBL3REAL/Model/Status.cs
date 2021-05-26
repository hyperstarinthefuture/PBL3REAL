using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("status")]
    public partial class Status
    {
        public Status()
        {
            StatusTimes = new HashSet<StatusTime>();
        }

        [Key]
        [Column("id_status")]
        public int IdStatus { get; set; }
        [Required]
        [Column("sta_name")]
        [StringLength(100)]
        public string StaName { get; set; }
        [Column("sta_description")]
        [StringLength(200)]
        public string StaDescription { get; set; }

        [InverseProperty(nameof(StatusTime.StatimIdstatusNavigation))]
        public virtual ICollection<StatusTime> StatusTimes { get; set; }
    }
}
