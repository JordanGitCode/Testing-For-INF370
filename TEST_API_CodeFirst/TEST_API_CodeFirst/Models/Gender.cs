using System.ComponentModel.DataAnnotations;

namespace TEST_API_CodeFirst.Models
{
    public class Gender
    {
        [Key]
        public int Gender_ID { get; set; }
        public string GenderText { get; set; } = string.Empty;
    }
}
