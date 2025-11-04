using Microsoft.EntityFrameworkCore;
using NetWithVueAndAspire.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddServiceDefaults();

builder.AddSqliteDbContext<EmbroideryDbContext>(name: "sqlite");

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IImageService, ImageService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Serve files in wwwroot (so /images/sample1.jpg is available when added to Api/wwwroot/images)
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<EmbroideryDbContext>();
await context.Database.MigrateAsync();

app.Run();
