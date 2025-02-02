using System;

namespace Basket.Service.Infrastructure.RabbitMq;

public static class RabbitMqExtensions
{
    public static void AddRabbitMqEventBus(this IServiceCollection services,
        IConfiguration configuration)
        {
            var rabbitMqOptions = new RabbitMqOptions();
            configuration.GetSection(RabbitMqOptions.RabbitMqSectionName).Bind(rabbitMqOptions);

            services.AddSingleton<IRabbitMqConnection>(new RabbitMqConnection(rabbitMqOptions));
        }
}
