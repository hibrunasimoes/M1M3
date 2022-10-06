using System;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Infra.Data.Repositories;

namespace DEVinCar.Api.Config.IOC
{
    public class RepositoryIoC
    {
        public static void RegisterServices(IServiceCollection builder)
    {
        builder.AddScoped<IAddressRepositorio, AddressRepositorio>();
        builder.AddScoped<ICarRepositorio, CarRepositorio>();
        builder.AddScoped<ICityRepositorio, CityRepositorio>();
        builder.AddScoped<IDeliveryRepositorio, DeliveryRepositorio>();
        builder.AddScoped<IUserRepositorio, UserRepositorio>();
        builder.AddScoped<ISaleRepositorio, SaleRepositorio>();
        builder.AddScoped<ISaleCarRepositorio, SaleCarRepositorio>();
        builder.AddScoped<IStateRepositorio, StateRepositorio>();

        }
    }
}