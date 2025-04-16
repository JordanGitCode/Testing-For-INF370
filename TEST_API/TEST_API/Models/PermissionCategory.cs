using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("PermissionCategory")]
public partial class PermissionCategory
{
    [Key]
    [Column("PermissionCategory_ID")]
    public int PermissionCategoryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    //[InverseProperty("PermissionCategory")]
    //public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
