var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "v1");

app.Run();


