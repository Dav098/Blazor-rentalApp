using MediatR;

namespace RentalApp.Features.Clients
{
    public class AddClientCommand : IRequest<int>
{
    public string Name { get; }
    public string Contact { get; }
    public bool IsBlocked { get; }

    public AddClientCommand(string name, string contact, bool isBlocked)
    {
        Name = name;
        Contact = contact;
        IsBlocked = isBlocked;
    }
}

}
