using GRPCServiceDemo.Repositories;
using GRPCServiceDemo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddScoped<IRepository, OrderRepository>();
var app = builder.Build();

app.MapGrpcService<OrderService>();
app.MapGet("/", () => "Hello World!");
app.Run();

