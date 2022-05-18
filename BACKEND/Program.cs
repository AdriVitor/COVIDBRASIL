using Covid.Data;
using COVID.DataContext;
using COVID.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration["ConnectionStrings:DefaultConnection"];

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connection)
);


var app = builder.Build();
app.UseCors(c => {
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

// O Código abaixo está comentado porque foi usado apenas para persistir as informações no Banco de Dados
	
// using (var scope = app.Services.CreateScope())
//     {
//         var services = scope.ServiceProvider;
//         var context = services.GetRequiredService<AppDbContext>();
//         DbInitialize.Initialize(context);
        
//     }


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
