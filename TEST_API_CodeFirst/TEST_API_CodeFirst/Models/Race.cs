using System.ComponentModel.DataAnnotations;

namespace TEST_API_CodeFirst.Models
{
    public class Race
    {
        [Key]
        public int Race_ID { get; set; }
        public string RaceText { get; set; } = string.Empty;
    }
}
