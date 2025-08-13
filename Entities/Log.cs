namespace RentalApp.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Operation { get; set; } = string.Empty;
        public string UserData { get; set; } = string.Empty;
    }
}
