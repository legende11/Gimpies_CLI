using Carter;
using Microsoft.AspNetCore.Builder;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
var app = builder.Build();
app.MapCarter();
app.Run();


