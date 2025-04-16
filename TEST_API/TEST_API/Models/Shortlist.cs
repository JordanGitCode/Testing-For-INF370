using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Shortlist")]
public partial class Shortlist
{
    [Key]
    [Column("Shortlist_ID")]
    public int ShortlistId { get; set; }

    [Column("Vacancy_ID")]
    public int? VacancyId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Stage { get; set; }

    [InverseProperty("Shortlist")]
    public virtual ICollection<ShortlistedCandidate> ShortlistedCandidates { get; set; } = new List<ShortlistedCandidate>();

    [ForeignKey("VacancyId")]
    [InverseProperty("Shortlists")]
    public virtual Vacancy Vacancy { get; set; }
}
