using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[PrimaryKey("ConversationId", "UserId")]
[Table("ConverationParticipant")]
public partial class ConverationParticipant
{
    [Key]
    [Column("Conversation_ID")]
    public int ConversationId { get; set; }

    [Key]
    [Column("User_ID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? JoinedAt { get; set; }

    [ForeignKey("ConversationId")]
    [InverseProperty("ConverationParticipants")]
    public virtual Conversation Conversation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ConverationParticipants")]
    public virtual User User { get; set; }
}
