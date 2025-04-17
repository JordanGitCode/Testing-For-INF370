using System.ComponentModel.DataAnnotations;

namespace TEST_API_CodeFirst.Models
{
    public class Title
    {
        [Key]
        public int Title_ID { get; set; }
        public string TitleText { get; set; } = string.Empty;
    }
}
