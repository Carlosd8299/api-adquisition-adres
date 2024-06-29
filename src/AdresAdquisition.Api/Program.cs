using AdresAcquisition.Api.MIddleware;
using AdresAdquisition.Domain.Interfaces;
using AdresAdquisition.Infraestructure.DataAccess;
using AdresAdquisition.Infraestructure.Interfaces;
using AdresAdquisition.Infraestructure.Repositories;
using AdresAcquisition.Aplication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddTransient<IAdquisicionRepository, AdquisicionRepository>();
builder.Services.AddTransient<ILogHistoricoRepository, LogHistoricoRepository>();

////Entity Framework
builder.Services.AddContextExtension(builder.Configuration);

// MediaTr
builder.Services.AddMediatorExtension();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                      });
});


var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
