using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace TEST_API_CodeFirst.Models
{
    public class User
    {
        [Key]
        public int User_ID { get; set; }

        public int? Title_ID { get; set; }
        public int? Race_ID { get; set; }
        public int? Gender_ID { get; set; }
        public int? Role_ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string IDNumber { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string PasswordHash { get; set; } = string.Empty;

        public string CurrentPosition { get; set; } = string.Empty;

        // Navigation properties (optional but recommended)
        public virtual Title? Title { get; set; }
        public virtual Race? Race { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual Role? Role { get; set; }
    }
}
