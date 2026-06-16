using ContaCerta.Api.Domain.Enums;

namespace ContaCerta.Api.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String PasswordHash { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public bool isActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt {  get; set; }

    }
}
