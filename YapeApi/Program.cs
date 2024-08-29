using YapeApi.Data;
using Microsoft.EntityFrameworkCore;
using YapeApi.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<SomethingContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("MySQLConnection"));
});

builder.Services.AddScoped<ISomethingRepository, SomethingRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();