using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Gender")]
public partial class Gender
{
    [Key]
    [Column("Gender_ID")]
    public int GenderId { get; set; }

    [Column("Gender")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gender1 { get; set; }

    [InverseProperty("Gender")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
