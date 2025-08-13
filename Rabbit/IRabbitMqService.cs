namespace RentalApp.Rabbit
{
    public interface IRabbitMqService
    {
        Task SendLogAsync(LogMessage logMessage);
    }
}
