using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Interview")]
public partial class Interview
{
    [Key]
    [Column("Interview_ID")]
    public int InterviewId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Employee_ID")]
    public int? EmployeeId { get; set; }

    [Column("Vacancy_ID")]
    public int? VacancyId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Location { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Status { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Result { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string InterviewType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string InterviewRound { get; set; }

    public int? Duration { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Score { get; set; }

    //[ForeignKey("EmployeeId")]
    //[InverseProperty("Interviews")]
    //public virtual Employee Employee { get; set; }

    //[InverseProperty("Interview")]
    //public virtual ICollection<InterviewFeedback> InterviewFeedbacks { get; set; } = new List<InterviewFeedback>();

    //[InverseProperty("Interview")]
    //public virtual ICollection<InterviewNote> InterviewNotes { get; set; } = new List<InterviewNote>();

    //[ForeignKey("UserId")]
    //[InverseProperty("Interviews")]
    //public virtual User User { get; set; }

    //[ForeignKey("VacancyId")]
    //[InverseProperty("Interviews")]
    //public virtual Vacancy Vacancy { get; set; }
}
