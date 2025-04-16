using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Job")]
public partial class Job
{
    [Key]
    [Column("Job_ID")]
    public int JobId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Title { get; set; }

    [Column(TypeName = "text")]
    public string Description { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Location { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SalaryRangeMin { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SalaryRangeMax { get; set; }

    public int? NumberVacancies { get; set; }

    [InverseProperty("Job")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [InverseProperty("Job")]
    public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
