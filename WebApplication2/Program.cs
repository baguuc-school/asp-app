using WebApplication2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet(
    "/", 
    () => Results.Ok("Hello, World!")
);

app.MapPost(
    "/",
    (TestDTO dto) => Results.Ok($"Hello, {dto.Name}, you are {dto.Age} years old.")
);

app.Run();