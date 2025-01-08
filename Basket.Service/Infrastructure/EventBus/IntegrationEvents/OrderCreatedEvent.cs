namespace Basket.Service.Infrastructure.EventBus.IntegrationEvents;

public record OrderCreatedEvent(string CustomerId) : Event;
