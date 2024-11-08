using TaskManagerAPIa.Model;

namespace TaskManagerAPIa.DTO
{
    public class registrationrequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
    }
}
