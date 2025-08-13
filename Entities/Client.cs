namespace RentalApp.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public bool IsBlocked { get; set; }
    }
}