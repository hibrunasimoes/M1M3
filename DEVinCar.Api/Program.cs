using System.Text;
using System.Text.Json.Serialization;
using DEVinCar.Api.Config;
using DEVinCar.Api.Config.IOC;
using DEVinCar.Api.Data;
using DEVinCar.Api.Security;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;
using DEVinCar.Domain.Services;
using DEVinCar.Infra.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc(config =>
{
    config.ReturnHttpNotAcceptable = true;
    config.OutputFormatters.Add(new XmlSerializerOutputFormatter());
    config.InputFormatters.Add(new XmlSerializerInputFormatter(config));

});
var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddAuthentication(x =>//authentication 
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});



builder.Services.AddDbContext<DevInCarDbContext>();

RepositoryIoC.RegisterServices(builder.Services);


//services

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<ISaleCarService, SaleCarService>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<IDeliveryService, DeliveryService>();

var app = builder.Build();

app.UseMiddleware<ErrorMiddleware>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// comentando para conseguir trabalhar com Insomnia/Postman via http comum
//app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
