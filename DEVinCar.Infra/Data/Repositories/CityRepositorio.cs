using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class CityRepositorio : BaseRepositorio<City, int>, ICityRepositorio
    {
        public CityRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }
    }
}

