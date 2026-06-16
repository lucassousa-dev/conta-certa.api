using ContaCerta.Api.Domain.Enums;

namespace ContaCerta.Api.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
