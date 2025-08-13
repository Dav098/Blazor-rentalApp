namespace RentalApp.Rabbit
{
    public class LogMessage
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Operation { get; set; } = "";
        public string UserData { get; set; } = "";
    }
}
