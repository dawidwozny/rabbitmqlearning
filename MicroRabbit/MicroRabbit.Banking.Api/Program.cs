using MediatR;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Infra.IoC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




builder.Services.RegisterServices();
builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddDbContext<BankingDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDBConnection"));
});

builder.Services.AddTransient<IMediator, Mediator>();


var app = builder.Build();

app.Run();

