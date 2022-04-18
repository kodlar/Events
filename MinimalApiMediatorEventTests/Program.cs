using MediatR;
using MinimalApiMediatorEventTests;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddTransient<TransientService>();
builder.Services.AddHostedService<TickerBackgroundService>();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.Run();

