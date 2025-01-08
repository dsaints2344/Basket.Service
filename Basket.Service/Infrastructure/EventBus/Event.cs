namespace Basket.Service.Infrastructure.EventBus;

public record class Event
{
    public Event()
    {
        Id = Guid.NewGuid();
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set;}
}
