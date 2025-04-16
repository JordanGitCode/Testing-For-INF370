using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("UserSession")]
public partial class UserSession
{
    [Key]
    [Column("UserSession_ID")]
    public int UserSessionId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Session_Start", TypeName = "datetime")]
    public DateTime? SessionStart { get; set; }

    [Column("Session_End", TypeName = "datetime")]
    public DateTime? SessionEnd { get; set; }

    //[ForeignKey("UserId")]
    //[InverseProperty("UserSessions")]
    //public virtual User User { get; set; }
}
