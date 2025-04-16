using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Permission")]
public partial class Permission
{
    [Key]
    [Column("Permission_ID")]
    public int PermissionId { get; set; }

    [Column("PermissionCategory_ID")]
    public int? PermissionCategoryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    [ForeignKey("PermissionCategoryId")]
    [InverseProperty("Permissions")]
    public virtual PermissionCategory PermissionCategory { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}
