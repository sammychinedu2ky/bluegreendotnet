var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "v4");

app.Run();


