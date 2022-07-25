using APICandidatos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("programacandidatosBD",
        new Microsoft.OpenApi.Models.OpenApiInfo()
        {
            Title = "programacandidatosBD (Candidato)",
            Version = "1",
            Description = "programacandidatosBD Candidato",
            Contact = new Microsoft.OpenApi.Models.OpenApiContact()
            {
                Name = "Grupo 2"
            },
            License = new Microsoft.OpenApi.Models.OpenApiLicense()
            {
                Name = "API fundamentals",
                Url = new Uri("https://www.udemy.com/course/quick-introduction-to-aspnet-mvc-core-20%22")

            }
        });
 });

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
