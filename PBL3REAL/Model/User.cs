using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            ImgStorages = new HashSet<ImgStorage>();
          //  Invoices = new HashSet<Invoice>();
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        [Column("id_user")]
        public int IdUser { get; set; }
        [Required]
        [Column("user_name")]
        [StringLength(100)]
        public string UserName { get; set; }
      
        [Required]
        [Column("user_gmail")]
        [StringLength(100)]
        public string UserGmail { get; set; }
        [Required]
        [Column("user_phone")]
        [StringLength(10)]
        public string UserPhone { get; set; }
        [Column("user_gender")]
        public bool UserGender { get; set; }
        [Column("user_activeflag")]
        public bool UserActiveflag { get; set; }
        [Column("user_code")]
        [StringLength(8)]
        public string UserCode { get; set; }

        [Required]
        [Column("user_password")]
        [StringLength(100)]
        public string UserPassword { get; set; }

        [InverseProperty(nameof(Booking.BookIduserNavigation))]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty(nameof(ImgStorage.ImgstoIduserNavigation))]
        public virtual ICollection<ImgStorage> ImgStorages { get; set; }
        /*[InverseProperty(nameof(Invoice.InvIduserNavigation))]
        public virtual ICollection<Invoice> Invoices { get; set; }*/
        [InverseProperty(nameof(UserRole.UserolIduserNavigation))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
