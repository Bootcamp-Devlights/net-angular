using InterviewApp_BL.Services;
using InterviewApp_DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<InterviewAppDbContext>(
    options => options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = InterviewAppDatabase2"));

builder.Services.AddScoped<IQuestionsService, QuestionsService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddTransient<IQuestionsService, QuestionsService>();
//builder.Services.AddScoped<IQuestionsService, QuestionsService>();
//builder.Services.AddSingleton<IQuestionsService, QuestionsService>(); //Singleton es un patrón

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
