using MediatR;
using RentalApp.Data;
using RentalApp.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RentalApp.Features.EquipmentF
{
    public class AddEquipmentCommandHandler : IRequestHandler<AddEquipmentCommand, Equipment>
    {
        private readonly RentalDbContext _context;

        public AddEquipmentCommandHandler(RentalDbContext context)
        {
            _context = context;
        }

        public async Task<Equipment> Handle(AddEquipmentCommand request, CancellationToken cancellationToken)
        {
            var equipment = new Equipment
            {
                Name = request.Name,
                EAN = request.EAN,
                IsAvailable = true
            };

            _context.Equipment.Add(equipment);

            await _context.SaveChangesAsync(cancellationToken);

            return equipment;
        }
    }
}
