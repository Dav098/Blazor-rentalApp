using Microsoft.EntityFrameworkCore;
using RentalApp.Data;
using MediatR;
using RentalApp.Rabbit;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja połączenia do PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
                       ?? "Host=localhost;Database=rentaldb;Username=postgres;Password=postgres";

// Dodaj DbContext z PostgreSQL
builder.Services.AddDbContext<RentalDbContext>(options =>
    options.UseNpgsql(connectionString));

// Dodaj MediatR - zakładam, że masz w projekcie handlery w namespace RentalApp.Application
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

builder.Services.AddSingleton<IRabbitMqService, RabbitMqService>();
builder.Services.AddHostedService<RabbitMqConsumerService>(); // jeśli chcesz odbierać i zapisywać logi w tym samym projekcie


// Dodaj Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Automatyczna migracja bazy danych przy starcie (opcjonalnie)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<RentalDbContext>();
    db.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
