using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Race")]
public partial class Race
{
    [Key]
    [Column("Race_ID")]
    public int RaceId { get; set; }

    [Column("Race")]
    [StringLength(50)]
    [Unicode(false)]
    public string Race1 { get; set; }

    //[InverseProperty("Race")]
    //public virtual ICollection<User> Users { get; set; } = new List<User>();
}
