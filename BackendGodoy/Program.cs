using BackendGodoy.Models;
using BackendGodoy.Repository;
using BackendGodoy.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IFactRepository, FactRepository>();
builder.Services.AddScoped<IGifRepository, GifRepository>();
builder.Services.AddScoped<IHistoryDataRepository, HistoryRepository>();

builder.Services.AddScoped<HistoryService>();
builder.Services.AddScoped<FactService>();
builder.Services.AddScoped<GifService>();


builder.Services.AddDbContext<CatFactsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CatFactConnection"));   
});
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        policy =>
        {
            policy.WithOrigins("*")  
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowSpecificOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
