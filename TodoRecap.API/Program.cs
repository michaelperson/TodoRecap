using ConnectDB;
using ConnectDB.Interfaces;
using ConnectDB.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//c'est ici que tu peux préparer les instances à envoyer vers les controller
string cnstr = builder.Configuration.GetConnectionString("Dev");
builder.Services.AddScoped<IRepository<ToDoEntity, int>>
    (
        (s) =>
        {
            return new TodoRepository(cnstr);
        }
    );
builder.Services.AddScoped<IRepository<UserEntity, int>>
    (
        (s) =>
        {
            return new UserRepository(cnstr);
        }
    );



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
