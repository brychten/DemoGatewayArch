using Ocelot.Middleware;
using Ocelot.DependencyInjection;
using Steeltoe.Discovery.Client;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Eureka;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Agregar Eureka Discovery Client
builder.Services.AddDiscoveryClient(builder.Configuration);
builder.Services.AddOcelot().AddEureka();

// Configuracion previa sin eureka 
// builder.Configuration.AddJsonFile("ocelot.json");
// builder.Services.AddOcelot();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Usar Discovery Client para Eureka 
app.UseDiscoveryClient();

await app.UseOcelot();
// app.MapGet("/", () => "Hello World!");

app.Run();

