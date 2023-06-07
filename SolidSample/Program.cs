using Microsoft.EntityFrameworkCore;
using SolidSample.Model;
using SolidSample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("SolidSample"));

builder.Services.AddScoped<IRepository<AudioBook>, AudioBooksRepository>();
builder.Services.AddTransient<IUpdatableRepository<AudioBook>>(provider => provider.GetRequiredService<IRepository<AudioBook>>());
builder.Services.AddTransient<IQueryableRepository<AudioBook>>(provider => provider.GetRequiredService<IRepository<AudioBook>>());

builder.Services.AddSingleton<SolidSample.Services.ILogger, FileLogger>();

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
