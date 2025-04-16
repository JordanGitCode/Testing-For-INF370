using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[PrimaryKey("UserId", "ShortlistId")]
[Table("ShortlistedCandidate")]
public partial class ShortlistedCandidate
{
    [Key]
    [Column("User_ID")]
    public int UserId { get; set; }

    [Key]
    [Column("Shortlist_ID")]
    public int ShortlistId { get; set; }

    [ForeignKey("ShortlistId")]
    [InverseProperty("ShortlistedCandidates")]
    public virtual Shortlist Shortlist { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ShortlistedCandidates")]
    public virtual User User { get; set; }
}
