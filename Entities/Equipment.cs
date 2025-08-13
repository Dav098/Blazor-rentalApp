namespace RentalApp.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string EAN { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
    }
}
