using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface IDeliveryRepositorio
    {
        IList<Delivery> ObterTodos();

        public IQueryable<Delivery> QueryMetodo();

        Delivery ObterPorId(int id);

    }
}


