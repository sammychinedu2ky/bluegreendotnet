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
app.MapGet("/calc/add/{a}/{b}", (int a, int b) => $"{a} + {b} = {Calc.Add(a, b)}");
app.Run();

public static class  Calc {
    public static int init = 0;
    public static int Add(int a, int b){
        
        return a + b + init++;
    }
}


