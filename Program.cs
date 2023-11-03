using DotNetEnv;


  
Env.Load();
var frontEndUrl = Environment.GetEnvironmentVariable("FRONTEND_URL");

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["Access-Control-Allow-Origin"] = frontEndUrl;

    if (HttpMethods.IsOptions(ctx.Request.Method))
    {
        ctx.Response.Headers["Access-Control-Allow-Headers"] = "*";
        ctx.Response.Headers["Access-Control-Allow-Methods"] = "GET, POST, PUT, DELETE";

        await ctx.Response.CompleteAsync();
        return;
    }

    await next();
});

app.MapGet("/get-arithmetic-mp", () => Multiplication.GetRandomMultiplication());
app.MapGet("/get-arithmetic-mn", () => Multiplication.GetRandomNegativeMultiplication());

app.MapGet("/get-arithmetic-dp", () => Division.GetRandomDivision());
app.MapGet("/get-arithmetic-dn", () => Division.GetRandomNegativeDivision());

app.MapGet("/get-arithmetic-mdp", () => BothArithmetics.GetRandomArithmetic());
app.MapGet("/get-arithmetic-mdn", () => BothArithmetics.GetRandomNegativeArithmetic());





app.Run();
