using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("room")]
    public partial class Room
    {
        public Room()
        {
            BookingDetails = new HashSet<BookingDetail>();
            StatusTimes = new HashSet<StatusTime>();
        }

        [Key]
        [Column("id_room")]
        public int IdRoom { get; set; }
        [Required]
        [Column("room_name")]
        [StringLength(100)]
        public string RoomName { get; set; }
        [Column("room_description")]
        [StringLength(250)]
        public string RoomDescription { get; set; }
        [Column("room_idroomtype")]
        public int RoomIdroomtype { get; set; }

        [Column("room_activeflag")]
        public bool RoomActiveflag { get; set; }

        [ForeignKey(nameof(RoomIdroomtype))]
        [InverseProperty(nameof(RoomType.Rooms))]
        public virtual RoomType RoomIdroomtypeNavigation { get; set; }
        [InverseProperty(nameof(BookingDetail.BoodetIdroomNavigation))]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        [InverseProperty(nameof(StatusTime.StatimIdroomNavigation))]
        public virtual ICollection<StatusTime> StatusTimes { get; set; }
    }
}
