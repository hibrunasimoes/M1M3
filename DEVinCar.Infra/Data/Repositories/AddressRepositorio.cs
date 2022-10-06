using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class AddressRepositorio : BaseRepositorio<Address, int>, IAddressRepositorio
    {
        public AddressRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }
    }
}


