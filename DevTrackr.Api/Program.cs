using DevTrackr.Core.Entities;
using DevTrackr.Core.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In-memory storage for tasks
var tasks = new List<TaskItem>();
int nextId = 1;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// GET /tasks - Get all tasks
app.MapGet("/tasks", () =>
{
    return tasks;
})
.WithName("GetTasks");

// GET /tasks/{id} - Get a task by ID
app.MapGet("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    return task is not null ? Results.Ok(task) : Results.NotFound();
})
.WithName("GetTask");

// POST /tasks - Create a new task
app.MapPost("/tasks", ([FromBody] TaskItem task) =>
{
    task.Id = nextId++;
    task.CreatedAt = DateTime.UtcNow;
    tasks.Add(task);
    return Results.Created($"/tasks/{task.Id}", task);
})
.WithName("CreateTask");

// PUT /tasks/{id} - Update a task
app.MapPut("/tasks/{id}", (int id, [FromBody] TaskItem updatedTask) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task is null)
    {
        return Results.NotFound();
    }

    task.Title = updatedTask.Title;
    task.Description = updatedTask.Description;
    task.DueDate = updatedTask.DueDate;
    task.Status = updatedTask.Status;

    return Results.Ok(task);
})
.WithName("UpdateTask");

// DELETE /tasks/{id} - Delete a task
app.MapDelete("/tasks/{id}", (int id) =>
{
    var task = tasks.FirstOrDefault(t => t.Id == id);
    if (task is null)
    {
        return Results.NotFound();
    }

    tasks.Remove(task);
    return Results.NoContent();
})
.WithName("DeleteTask");

app.Run();