using MediatR;
using RentalApp.Entities;

namespace RentalApp.Features.EquipmentF
{
    public class AddEquipmentCommand : IRequest<Equipment>
    {
        public string Name { get; set; }
        public string EAN { get; set; }
        public bool IsAvailable { get; set; }
    }
}
