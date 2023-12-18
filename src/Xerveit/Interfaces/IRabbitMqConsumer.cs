using RabbitMQ.Client;

namespace Xerveit.Core.Interfaces
{
    public interface IRabbitMqConsumer
    {
        IConnection CreateChannel();
    }
}
