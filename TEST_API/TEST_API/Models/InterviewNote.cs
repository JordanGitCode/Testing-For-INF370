using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("InterviewNote")]
public partial class InterviewNote
{
    [Key]
    [Column("InterviewNote_ID")]
    public int InterviewNoteId { get; set; }

    [Column("Interview_ID")]
    public int? InterviewId { get; set; }

    [Column(TypeName = "text")]
    public string Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedAt { get; set; }

    //[ForeignKey("InterviewId")]
    //[InverseProperty("InterviewNotes")]
    //public virtual Interview Interview { get; set; }
}
