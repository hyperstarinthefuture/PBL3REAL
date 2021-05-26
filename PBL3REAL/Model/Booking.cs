using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("booking")]
    public partial class Booking
    {
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        [Column("id_book")]
        public int IdBook { get; set; }
        [Column("book_bookdate", TypeName = "date")]
        public DateTime BookBookdate { get; set; }
        [Column("book_checkindate", TypeName = "date")]
        public DateTime BookCheckindate { get; set; }
        [Column("book_idclient")]
        public int BookIdclient { get; set; }
        [Column("book_note")]
        [StringLength(600)]
        public string BookNote { get; set; }
        [Required]
        [Column("book_status")]
        [StringLength(10)]
        public string BookStatus { get; set; }
        [Column("book_deposit")]
        public int BookDeposit { get; set; }
        [Column("book_totalprice")]
        public int BookTotalprice { get; set; }
        [Column("book_checkoutdate", TypeName = "date")]
        public DateTime BookCheckoutdate { get; set; }

        [Column("book_duedate", TypeName = "date")]
        public DateTime BookDuedate { get; set; }
        [Column("book_iduser")]
        public int BookIduser { get; set; }

        [Column("book_code")]
        [StringLength(8)]
        public string BookCode { get; set; }

        [ForeignKey(nameof(BookIdclient))]
        [InverseProperty(nameof(Client.Bookings))]
        public virtual Client BookIdclientNavigation { get; set; }
        [ForeignKey(nameof(BookIduser))]
        [InverseProperty(nameof(User.Bookings))]
        public virtual User BookIduserNavigation { get; set; }
        [InverseProperty("InvIdbookNavigation")]
        public virtual Invoice Invoice { get; set; }
        [InverseProperty(nameof(BookingDetail.BoodetIdbookNavigation))]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }

    }
}
