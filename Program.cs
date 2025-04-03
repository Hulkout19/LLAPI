// using System.Text.Json;
// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
// builder.Services.AddControllers();
// builder.Services.AddEndpointsApiExplorer();


// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// Game game = new Game();
// app.MapGet("/weatherforecast", () =>
// {
//     // var forecast =  Enumerable.Range(1, 5).Select(index =>
//     //     new WeatherForecast
//     //     (
//     //         DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//     //         Random.Shared.Next(-20, 55),
//     //         summaries[Random.Shared.Next(summaries.Length)]
//     //     ))
//     //     .ToArray();
//     List<string> gameList = new List<string>();
//     gameList.Add(game.myValue);

//     string fileName = "WeatherForecast.json"; 
//     string jsonString = JsonSerializer.Serialize(game);
//     File.WriteAllText(fileName, jsonString);
//     return File.ReadAllText(fileName);
// })
// .WithName("GetWeatherForecast");

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200") // Angular Dev Server
                  .AllowAnyMethod()
                  .AllowAnyHeader()
                  .AllowCredentials(); // Required if using authentication cookies or headers
        });
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();

app.UseCors("AllowAngularApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
