using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("booking_detail")]
    public partial class BookingDetail
    {
        [Key]
        [Column("id_boodet")]
        public int IdBoodet { get; set; }
        
        [Column("boodet_price")]
        public int BoodetPrice { get; set; }
        [Column("boodet_idbook")]
        public int BoodetIdbook { get; set; }
        [Column("boodet_idroom")]
        public int BoodetIdroom { get; set; }

        [Column("boodet_idroomtype")]
        public string BoodetRoTyCode { get; set; }

        [Column("boodet_note")]
        [StringLength(200)]
        public string BooDetNote { get; set; }

        [ForeignKey(nameof(BoodetIdbook))]
        [InverseProperty(nameof(Booking.BookingDetails))]
        public virtual Booking BoodetIdbookNavigation { get; set; }
        [ForeignKey(nameof(BoodetIdroom))]
        [InverseProperty(nameof(Room.BookingDetails))]
        public virtual Room BoodetIdroomNavigation { get; set; }
    }
}
