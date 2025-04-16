using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Title")]
public partial class Title
{
    [Key]
    [Column("Title_ID")]
    public int TitleId { get; set; }

    [Column("Title")]
    [StringLength(50)]
    [Unicode(false)]
    public string Title1 { get; set; }

    //[InverseProperty("Title")]
    //public virtual ICollection<User> Users { get; set; } = new List<User>();
}
