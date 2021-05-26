using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("Invoice")]
    [Index(nameof(InvIdbook), Name = "UQ__Invoice__95EA4EA85B668B59", IsUnique = true)]
    public partial class Invoice
    {
        [Key]
        [Column("id_invoice")]
        public int IdInvoice { get; set; }
        [Column("inv_createdate", TypeName = "date")]
        public DateTime InvCreatedate { get; set; }
        [Column("inv_updatedate", TypeName = "date")]
        public DateTime InvUpdatedate { get; set; }
        [Required]
        [Column("inv_code")]
        [StringLength(8)]
        public string InvCode { get; set; }
        [Column("inv_idbook")]
        public int InvIdbook { get; set; }

        [Column("inv_total")]
        public int TotalPrice { get; set; }

        [ForeignKey(nameof(InvIdbook))]
        [InverseProperty(nameof(Booking.Invoice))]
        public virtual Booking InvIdbookNavigation { get; set; }
    }
}
