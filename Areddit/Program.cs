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


// Tilf�j DataService s� den kan bruges i endpoints
builder.Services.AddScoped<DataService>();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dataService = scope.ServiceProvider.GetRequiredService<DataService>();
    dataService.SeedData(); // Fylder data p�, hvis databasen er tom. Ellers ikke.
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
    return service.GetPosts();
});

app.MapGet("/api/posts/{id}", (DataService service, int id) =>
{
    return service.GetPost(id);
});

app.MapPost("/api/posts", (DataService service, NewPostData data) =>
{
    string result = service.CreatePost(data.Title, data.Text, data.User);
    return new { message = result };
});


app.MapPost("/api/posts/{id}/comments", (DataService service, NewCommentData data, int id) =>
{
    string result = service.CreateComment(data.CommentText, data.CommentUser, id);
    return new { message = result };
});

app.MapPut("api/posts/{id}/upvote", (DataService service, int id) =>
{
    return service.UpvotePost(id);
});

app.MapPut("api/posts/{id}/downvote", (DataService service, int id) =>
{
    return service.DownvotePost(id);
});

app.MapPut("api/comments/{id}/upvote", (DataService service, int id) =>
{
    return service.UpvoteComment(id);
});

app.MapPut("api/comments/{id}/downvote", (DataService service, int id) =>
{
    return service.DownvoteComment(id);
});


app.Run();

record NewPostData(string Title, string Text, string User);
record NewCommentData(string CommentText, string CommentUser, int PostId);



// kjær != goat