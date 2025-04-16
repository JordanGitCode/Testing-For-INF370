using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("User_ID")]
    public int UserId { get; set; }

    [Column("Title_ID")]
    public int? TitleId { get; set; }

    [Column("Race_ID")]
    public int? RaceId { get; set; }

    [Column("Gender_ID")]
    public int? GenderId { get; set; }

    [Column("Role_ID")]
    public int? RoleId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Surname { get; set; }

    [Column("IDNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string Idnumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PhoneNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EmailAddress { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [Column(TypeName = "text")]
    public string PasswordHash { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CurrentPosition { get; set; }

    //[InverseProperty("User")]
    //public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    //[InverseProperty("User")]
    //public virtual ICollection<ConverationParticipant> ConverationParticipants { get; set; } = new List<ConverationParticipant>();

    //[InverseProperty("User")]
    //public virtual ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();

    //[InverseProperty("User")]
    //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    //[ForeignKey("GenderId")]
    //[InverseProperty("Users")]
    //public virtual Gender Gender { get; set; }

    //[InverseProperty("User")]
    //public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    //[InverseProperty("User")]
    //public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    //[ForeignKey("RaceId")]
    //[InverseProperty("Users")]
    //public virtual Race Race { get; set; }

    //[ForeignKey("RoleId")]
    //[InverseProperty("Users")]
    //public virtual Role Role { get; set; }

    //[InverseProperty("User")]
    //public virtual ICollection<ShortlistedCandidate> ShortlistedCandidates { get; set; } = new List<ShortlistedCandidate>();

    //[ForeignKey("TitleId")]
    //[InverseProperty("Users")]
    //public virtual Title Title { get; set; }

    //[InverseProperty("User")]
    //public virtual ICollection<UserSession> UserSessions { get; set; } = new List<UserSession>();
}
