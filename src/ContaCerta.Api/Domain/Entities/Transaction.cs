using ContaCerta.Api.Domain.Enums;

namespace ContaCerta.Api.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
