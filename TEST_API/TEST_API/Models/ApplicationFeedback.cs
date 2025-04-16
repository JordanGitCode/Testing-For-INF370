using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("ApplicationFeedback")]
public partial class ApplicationFeedback
{
    [Key]
    [Column("Feedback_ID")]
    public int FeedbackId { get; set; }

    [Column("Application_ID")]
    public int? ApplicationId { get; set; }

    [Column("Employee_ID")]
    public int? EmployeeId { get; set; }

    [Column(TypeName = "text")]
    public string Comment { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("ApplicationFeedbacks")]
    public virtual Application Application { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("ApplicationFeedbacks")]
    public virtual Employee Employee { get; set; }
}
