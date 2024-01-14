var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/name", () => "This is the name of Emmanuel Donkor");

app.Run();
