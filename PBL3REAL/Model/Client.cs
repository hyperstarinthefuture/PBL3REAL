using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("client")]
    public partial class Client
    {
        public Client()
        {
            Bookings = new HashSet<Booking>();
          /*  Invoices = new HashSet<Invoice>();*/
        }

        [Key]
        [Column("id_client")]
        public int IdClient { get; set; }
        [Required]
        [Column("cli_name")]
        [StringLength(100)]
        public string CliName { get; set; }
        [Column("cli_phone")]
        [StringLength(10)]
        public string CliPhone { get; set; }
        [Column("cli_code")]
        [StringLength(10)]
        public string CliCode { get; set; }
        [Required]
        [Column("cli_gmail")]
        [StringLength(100)]
        public string CliGmail { get; set; }

        [Column("cli_activeflag")]
        public bool CliActiveflag { get; set; }


        [InverseProperty(nameof(Booking.BookIdclientNavigation))]
        public virtual ICollection<Booking> Bookings { get; set; }
    /*    [InverseProperty(nameof(Invoice.InvIdclientNavigation))]
        public virtual ICollection<Invoice> Invoices { get; set; }*/
    }
}
