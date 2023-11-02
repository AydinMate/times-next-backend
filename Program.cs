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

app.MapGet("/get-random-multiplication", () => Multiplication.GetRandomMultiplication());

app.Run();
