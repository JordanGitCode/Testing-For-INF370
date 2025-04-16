using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Message")]
public partial class Message
{
    [Key]
    [Column("Message_ID")]
    public int MessageId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Conversation_ID")]
    public int? ConversationId { get; set; }

    [Column(TypeName = "text")]
    public string MessageText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SentAt { get; set; }

    [ForeignKey("ConversationId")]
    [InverseProperty("Messages")]
    public virtual Conversation Conversation { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Messages")]
    public virtual User User { get; set; }
}
