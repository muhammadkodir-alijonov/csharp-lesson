global using System.Net;
using CarShop.Api.Common.Configurations;
using CarShop.Api.Common.DbContexts;
using CarShop.Api.Common.Middlewares;
using CarShop.Api.Common.Security;
using CarShop.Api.Interfaces;
using CarShop.Api.Interfaces.Common;
using CarShop.Api.Services;
using CarShop.Api.Servicese;
using Microsoft.EntityFrameworkCore;

//-> Services
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaginationService, PaginatorService>();
builder.ConfigureAuth();
builder.Services.ConfigureSwaggerAuthorize(); //for swagger Auth
//database
string connectionString = builder.Configuration.GetConnectionString("database")!;
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

// Mapper
builder.Services.AddAutoMapper(typeof(MapperConfiguration));//error

// Logger
builder.ConfigureLogger();

//-> Middlewares
var app = builder.Build();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication(); //1
app.UseAuthorization(); //2
app.MapControllers();
app.Run();
