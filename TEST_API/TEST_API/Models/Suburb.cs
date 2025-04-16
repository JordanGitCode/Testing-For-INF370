using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Suburb")]
public partial class Suburb
{
    [Key]
    [Column("Suburb_ID")]
    public int SuburbId { get; set; }

    [Column("City_ID")]
    public int? CityId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    //[InverseProperty("Suburb")]
    //public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    //[ForeignKey("CityId")]
    //[InverseProperty("Suburbs")]
    //public virtual City City { get; set; }
}
