using HabitTrackerApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowFrontend");

List<Habit> habits = new List<Habit>();

app.MapGet("/", () =>
{
    return "Habit Tracker API is running!";
});

app.MapGet("/api/habits", () =>
{
    return Results.Ok(habits);
});

app.MapPost("/api/habits", (Habit habit) =>
{
    if (string.IsNullOrWhiteSpace(habit.Title))
    {
        return Results.BadRequest("Habit title is required.");
    }

    var newHabit = new Habit
    {
        Id = habits.Count + 1,
        Title = habit.Title,
        IsDone = false,
        CreatedAt = DateTime.Now
    };

    habits.Add(newHabit);

    return Results.Created($"/api/habits/{newHabit.Id}", newHabit);
});

app.Run();