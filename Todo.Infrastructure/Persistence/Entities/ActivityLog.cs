namespace Todo.Infrastructure.Persistence.Entities
{
    public class ActivityLog : BaseEntity
    {
        public string EntityName { get; set; }
        public Guid EntityId { get; set; }

        public string Action { get; set; }
        public string Performance { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;

        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}