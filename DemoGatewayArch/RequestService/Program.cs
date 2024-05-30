using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// Config Eureka 
builder.Services.AddDiscoveryClient(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Eureka para el autodiscover
app.UseDiscoveryClient();

//app.UseHttpsRedirection();
app.MapControllers();
app.Run();
