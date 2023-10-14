var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => html);

app.Run();

var html = $"""
<html>
    <head>
        <title>ASP.NET Core</title>
    </head>
    <body>
        <h1> V1 </h1>
    </body>
</html>
"""

