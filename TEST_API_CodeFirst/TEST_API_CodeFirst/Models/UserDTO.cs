namespace TEST_API_CodeFirst.Models
{
    public class UserDTO
    {
        public int User_ID { get; set; }

        public int? Title_ID { get; set; }
        public int? Race_ID { get; set; }
        public int? Gender_ID { get; set; }
        public int? Role_ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string IDNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PasswordHash { get; set; }

        public string CurrentPosition { get; set; }

    }
}
