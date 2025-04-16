using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Conversation")]
public partial class Conversation
{
    [Key]
    [Column("Conversation_ID")]
    public int ConversationId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Employee_ID")]
    public int? EmployeeId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Subject { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    //[InverseProperty("Conversation")]
    //public virtual ICollection<ConverationParticipant> ConverationParticipants { get; set; } = new List<ConverationParticipant>();

    //[ForeignKey("EmployeeId")]
    //[InverseProperty("Conversations")]
    //public virtual Employee Employee { get; set; }

    //[InverseProperty("Conversation")]
    //public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    //[ForeignKey("UserId")]
    //[InverseProperty("Conversations")]
    //public virtual User User { get; set; }
}
