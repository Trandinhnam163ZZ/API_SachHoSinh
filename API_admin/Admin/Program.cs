using BusinessLogicLayer;
using DataAccessLayer;
using DataAcessLayer;
using DataModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BusinessLogicLayer;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddTransient<IDatabaseHelper, DataBaseHelper>();

builder.Services.AddTransient<ISanPhamReposity, SanPhamReposity>();
builder.Services.AddTransient<ISanPhamBusiness, SanPhamBusiness>();

builder.Services.AddTransient<IKhachHangBusiness, KhachHangBusiness>();
builder.Services.AddTransient<IKhachHangReposity, KhachHangReposity>();



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
