using RabbitMQ.Client;

namespace Xerveit.Interfaces
{
    public interface IRabbitMqConsumer
    {
        IConnection CreateChannel();
    }
}
