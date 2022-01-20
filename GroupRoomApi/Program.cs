using Bookings.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddSingleton<IRoomRepository, RoomRepository>();
builder.Services.AddControllers();
builder.Services.AddDbContext<BookingsContext>
    (options => options.UseSqlite("Name=BookingsDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
