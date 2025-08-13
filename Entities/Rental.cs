using System;

namespace RentalApp.Entities
{
    public class Rental
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int EquipmentId { get; set; }

    public DateTime RentalDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    // relacje
    public Client Client { get; set; }
    public Equipment Equipment { get; set; }
}

}
