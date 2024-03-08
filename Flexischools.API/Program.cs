using Flexischools.Data;
using Flexischools.Services.DI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddFlexischoolsServices();

builder.Services.AddDbContext<FlexischoolsDBContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("FlexischoolsDBConn");
    options.UseSqlServer(connectionString);
});

builder.Services.AddControllers();
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
