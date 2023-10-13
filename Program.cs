var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "v3");

app.Run();


