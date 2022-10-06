using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class SaleCarRepositorio : BaseRepositorio<SaleCar, int>, ISaleCarRepositorio
    {
        public SaleCarRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }

    }
}

