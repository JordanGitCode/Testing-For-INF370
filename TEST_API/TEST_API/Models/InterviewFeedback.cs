using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("InterviewFeedback")]
public partial class InterviewFeedback
{
    [Key]
    [Column("Feedback_ID")]
    public int FeedbackId { get; set; }

    [Column("Interview_ID")]
    public int? InterviewId { get; set; }

    [Column(TypeName = "text")]
    public string Comment { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    [ForeignKey("InterviewId")]
    [InverseProperty("InterviewFeedbacks")]
    public virtual Interview Interview { get; set; }
}
