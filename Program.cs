var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var html = $"""
<html>
    <head>
        <title>ASP.NET Core</title>
    </head>
    <body>
        <h1> This is V1 </h1>
    </body>
</html>
""";

app.MapGet("/", () => Results.Content(html, "text/html"));

app.Run();


