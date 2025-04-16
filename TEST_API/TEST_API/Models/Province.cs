using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Province")]
public partial class Province
{
    [Key]
    [Column("Province_ID")]
    public int ProvinceId { get; set; }

    [Column("Country_ID")]
    public int? CountryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    //[InverseProperty("Province")]
    //public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    //[InverseProperty("Province")]
    //public virtual ICollection<City> Cities { get; set; } = new List<City>();

    //[ForeignKey("CountryId")]
    //[InverseProperty("Provinces")]
    //public virtual Country Country { get; set; }
}
