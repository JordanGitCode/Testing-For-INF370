using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Country")]
public partial class Country
{
    [Key]
    [Column("Country_ID")]
    public int CountryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    [InverseProperty("Country")]
    public virtual ICollection<Province> Provinces { get; set; } = new List<Province>();
}
