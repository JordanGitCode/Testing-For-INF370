using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

[Table("Employee")]
public partial class Employee
{
    [Key]
    [Column("Employee_ID")]
    public int EmployeeId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Branch_ID")]
    public int? BranchId { get; set; }

    [Column("Job_ID")]
    public int? JobId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? CurrentSalary { get; set; }

    public DateOnly? HireDate { get; set; }

    //[InverseProperty("Employee")]
    //public virtual ICollection<ApplicationFeedback> ApplicationFeedbacks { get; set; } = new List<ApplicationFeedback>();

    //[ForeignKey("BranchId")]
    //[InverseProperty("Employees")]
    //public virtual Branch Branch { get; set; }

    //[InverseProperty("Employee")]
    //public virtual ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();

    //[InverseProperty("Employee")]
    //public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    //[ForeignKey("JobId")]
    //[InverseProperty("Employees")]
    //public virtual Job Job { get; set; }

    //[ForeignKey("UserId")]
    //[InverseProperty("Employees")]
    //public virtual User User { get; set; }
}
