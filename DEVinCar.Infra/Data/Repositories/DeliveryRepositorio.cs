using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class DeliveryRepositorio : BaseRepositorio<Delivery, int>, IDeliveryRepositorio
    {
        public DeliveryRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }
    }
}

