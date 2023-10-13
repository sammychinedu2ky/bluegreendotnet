var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "v2");

app.Run();


