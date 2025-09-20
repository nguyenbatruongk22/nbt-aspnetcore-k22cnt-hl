var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!- Nguyen Ba Truong - 2210900140");

app.Run();
