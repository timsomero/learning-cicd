var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => new { message = "Hello, World!", timestamp = DateTime.UtcNow });

app.Run();