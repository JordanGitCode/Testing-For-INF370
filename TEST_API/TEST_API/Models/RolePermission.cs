using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[PrimaryKey("PermissionId", "RoleId")]
[Table("RolePermission")]
public partial class RolePermission
{
    [Key]
    [Column("Permission_ID")]
    public int PermissionId { get; set; }

    [Key]
    [Column("Role_ID")]
    public int RoleId { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("RolePermissions")]
    public virtual Permission Permission { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("RolePermissions")]
    public virtual Role Role { get; set; }
}
