using System.ComponentModel.DataAnnotations;

namespace TEST_API_CodeFirst.Models
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
