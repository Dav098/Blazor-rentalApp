using MediatR;
using RentalApp.Data;
using RentalApp.Entities;


namespace RentalApp.Features.Clients
{
    public class AddClientCommandHandler : IRequestHandler<AddClientCommand, int>
    {
        private readonly RentalDbContext _context;
        

        public AddClientCommandHandler(RentalDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                Name = request.Name,
                Contact = request.Contact,
                IsBlocked = request.IsBlocked
            };

            _context.Clients.Add(client);
            await _context.SaveChangesAsync(cancellationToken);

            

            return client.Id;
        }
    }
}
