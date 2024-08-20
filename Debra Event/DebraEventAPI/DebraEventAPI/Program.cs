using DebraEventAPI.Data;

using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
var conn = @"Data Source=MSI\DEBRA_NEW;User ID=sa;Password=1234;
            Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"
;

builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(conn));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IPartnerRepo, PartnerRepo>();
builder.Services.AddScoped<IAddEventRepo, AddEventRepo>();
builder.Services.AddScoped<ITicketRepo, TicketRepo>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();