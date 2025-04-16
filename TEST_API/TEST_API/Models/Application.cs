using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Application")]
public partial class Application
{
    [Key]
    [Column("Application_ID")]
    public int ApplicationId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    public DateOnly? DateApplied { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? SalaryExpectation { get; set; }

    [Column(TypeName = "text")]
    public string ApplicantNote { get; set; }

    //[InverseProperty("Application")]
    //public virtual ICollection<ApplicationFeedback> ApplicationFeedbacks { get; set; } = new List<ApplicationFeedback>();

    //[ForeignKey("UserId")]
    //[InverseProperty("Applications")]
    //public virtual User User { get; set; }

    //[InverseProperty("Application")]
    //public virtual ICollection<Vacancy> Vacancies { get; set; } = new List<Vacancy>();
}
