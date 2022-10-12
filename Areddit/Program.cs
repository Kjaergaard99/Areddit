using Data;
using Model;
using Microsoft.EntityFrameworkCore;
using System;
using Service;


var builder = WebApplication.CreateBuilder(args);

var AllowSomeStuff = "_AllowSomeStuff";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSomeStuff, builder => {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


builder.Services.AddDbContext<PostContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContextSQLite")));


// Tilføj DataService så den kan bruges i endpoints
builder.Services.AddScoped<DataService>();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dataService = scope.ServiceProvider.GetRequiredService<DataService>();
    dataService.SeedData(); // Fylder data på, hvis databasen er tom. Ellers ikke.
}

app.UseHttpsRedirection();
app.UseCors(AllowSomeStuff);

app.Use(async (context, next) =>
{
    context.Response.ContentType = "application/json; charset=utf-8";
    await next(context);
});


app.MapGet("/", (DataService service) =>
{
    return new { message = "Hello World!" };
});


app.MapGet("/api/posts", (DataService service) =>
{
    return service.GetPosts().Select(x => new { x.PostId, x.Title, x.Text, x.Date, x.Votes, x.User });
});




app.Run();
