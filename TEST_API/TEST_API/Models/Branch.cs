using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Branch")]
public partial class Branch
{
    [Key]
    [Column("Branch_ID")]
    public int BranchId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Address { get; set; }

    [Column("Country_ID")]
    public int? CountryId { get; set; }

    [Column("Province_ID")]
    public int? ProvinceId { get; set; }

    [Column("City_ID")]
    public int? CityId { get; set; }

    [Column("Suburb_ID")]
    public int? SuburbId { get; set; }

    //[ForeignKey("CityId")]
    //[InverseProperty("Branches")]
    //public virtual City City { get; set; }

    //[ForeignKey("CountryId")]
    //[InverseProperty("Branches")]
    //public virtual Country Country { get; set; }

    //[InverseProperty("Branch")]
    //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    //[ForeignKey("ProvinceId")]
    //[InverseProperty("Branches")]
    //public virtual Province Province { get; set; }

    //[ForeignKey("SuburbId")]
    //[InverseProperty("Branches")]
    //public virtual Suburb Suburb { get; set; }

    //[InverseProperty("Branch")]
    //public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
