using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Vacancy")]
public partial class Vacancy
{
    [Key]
    [Column("Vacancy_ID")]
    public int VacancyId { get; set; }

    [Column("Application_ID")]
    public int? ApplicationId { get; set; }

    [Column("Job_ID")]
    public int? JobId { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }

    public DateOnly? PostingDate { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public DateOnly? ApplicationDeadline { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("Vacancies")]
    public virtual Application Application { get; set; }

    [ForeignKey("BranchId")]
    [InverseProperty("Vacancies")]
    public virtual Branch Branch { get; set; }

    [InverseProperty("Vacancy")]
    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    [ForeignKey("JobId")]
    [InverseProperty("Vacancies")]
    public virtual Job Job { get; set; }

    [InverseProperty("Vacancy")]
    public virtual ICollection<Shortlist> Shortlists { get; set; } = new List<Shortlist>();
}
