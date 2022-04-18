using MinimalApiEventTests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TickerService>();
builder.Services.AddTransient<TransientService>();
builder.Services.AddHostedService<TickerBackgroundService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.Run();
