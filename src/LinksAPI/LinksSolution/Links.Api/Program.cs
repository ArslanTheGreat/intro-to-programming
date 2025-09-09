// This is compiling to an INTERNAL calss called the Program without a Namespace
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// everything above this line is "configuration: of the SERVICES that out Api needs to run
var app = builder.Build();
// Everything after this line up to "app.Run()" is "Middleware" -
// telling our API how it should handle actual HTTP Requests and Responses

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers(); // Create a phone book of possible things this API can expect 
// For example when someone does a POST 
// Route Table

app.Run(); // This is where our API will be up and running, listening for requests
// This is basically a while(true) {...} loop that will run "forever"


// Shortcut: ctrl f5 - runs

// I want to make this "Progam" class visible to my tests
public partial class Program;