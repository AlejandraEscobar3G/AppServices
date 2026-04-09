using AppServices.Interfaces;
using AppServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IDragonBallService, DragonBallService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "UHabitacionalAPI v1");
    c.RoutePrefix = string.Empty; // Para que abra en la raíz (http://localhost:5000/)
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
