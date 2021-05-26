using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("role")]
    public partial class Role
    {
        public Role()
        {
    
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        [Column("id_role")]
        public int IdRole { get; set; }
        [Required]
        [Column("role_name")]
        [StringLength(100)]
        public string RoleName { get; set; }
        [Column("role_description")]
        [StringLength(200)]
        public string RoleDescription { get; set; }

        
        [InverseProperty(nameof(UserRole.UserolIdroleNavigation))]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
