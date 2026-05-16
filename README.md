# RentalApp

RentalApp is a professional Blazor Server application for equipment rental management. It combines PostgreSQL, Entity Framework Core, RabbitMQ and a clean Blazor interface to manage clients, equipment and rental reservations.

## Key Capabilities

- add and manage clients
- add and manage equipment items
- create and delete rental reservations
- enforce equipment availability status
- persist data with PostgreSQL
- publish operation logs via RabbitMQ
- run as a Blazor Server app on .NET 8

## Architecture

- **Blazor Server** UI
- **Entity Framework Core** + PostgreSQL for data persistence
- **RabbitMQ** for asynchronous logging/event publishing
- **MediatR** registered for application messaging
- **Clean domain entities** for Client, Equipment, Rental and Log

## Main Pages

- `/addclient` — client registration and list
- `/equipment` — equipment registration and list
- `/rental` — rental reservation workflow and history

## Requirements

- .NET 8 SDK
- PostgreSQL
- RabbitMQ
- Docker Compose (recommended for local development)

## Local setup

1. Clone the repository.
2. Open the project in your IDE.
3. Configure PostgreSQL and RabbitMQ or use Docker Compose.

### Docker Compose

```bash
docker-compose up -d
```

This starts:

- PostgreSQL on `localhost:5432`
- RabbitMQ broker on `localhost:5672`
- RabbitMQ management UI on `http://localhost:15672`

### Connection string

The application uses the `DefaultConnection` setting from `appsettings.json`.
Update it if needed to match your database credentials.

## Run the application

```bash
dotnet run
```

Then open the app in your browser at `https://localhost:5001` or the console-provided URL.

## Notes

- The database is automatically migrated at startup.
- Equipment is only rentable when `IsAvailable` is true.
- Adding or deleting rentals updates availability and publishes a RabbitMQ log message.
- Clients can be marked as blocked to exclude them from new reservations.

## Project structure

- `Program.cs` — app startup, service registration and middleware
- `Data/RentalDbContext.cs` — EF Core DbContext
- `Entities/` — domain models for clients, equipment, rentals and logs
- `Pages/` — Blazor pages for clients, equipment and rentals
- `Rabbit/` — RabbitMQ service and consumer implementation

## Dependencies

- `Microsoft.EntityFrameworkCore` 8.0
- `Npgsql.EntityFrameworkCore.PostgreSQL` 8.0
- `MediatR` 12.0
- `RabbitMQ.Client` 6.4
- `AutoMapper.Extensions.Microsoft.DependencyInjection` 12.0

---

This README is optimized for GitHub: concise, factual and ready for developers to use and extend.
