using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace RentalApp.Rabbit
{
    public class RabbitMqService : IRabbitMqService, IDisposable
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly string _queueName;

        public RabbitMqService(IConfiguration configuration)
        {
            var factory = new ConnectionFactory()
            {
                HostName = configuration["RabbitMQ:HostName"] ?? "localhost",
                UserName = configuration["RabbitMQ:UserName"] ?? "guest",
                Password = configuration["RabbitMQ:Password"] ?? "guest"
            };

            _queueName = configuration["RabbitMQ:QueueName"] ?? "rental_logs_queue";

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(queue: _queueName,
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
        }

        public Task SendLogAsync(LogMessage logMessage)
        {
            var json = JsonSerializer.Serialize(logMessage);
            var body = Encoding.UTF8.GetBytes(json);

            var properties = _channel.CreateBasicProperties();
            properties.Persistent = true;

            _channel.BasicPublish(exchange: "",
                                 routingKey: _queueName,
                                 basicProperties: properties,
                                 body: body);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _channel?.Close();
            _connection?.Close();
        }
    }
}
