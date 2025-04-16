using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("City")]
public partial class City
{
    [Key]
    [Column("City_ID")]
    public int CityId { get; set; }

    [Column("Province_ID")]
    public int? ProvinceId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    //[InverseProperty("City")]
    //public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    //[ForeignKey("ProvinceId")]
    //[InverseProperty("Cities")]
    //public virtual Province Province { get; set; }

    //[InverseProperty("City")]
    //public virtual ICollection<Suburb> Suburbs { get; set; } = new List<Suburb>();
}
