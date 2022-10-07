using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface IDeliveryService
    {
        IList<Delivery> ObterTodos(int? id, int? addressId, int? saleId);
        DeliveryDTO ObterPorId(int id);
        public IQueryable<Delivery> QueryMetodo();
    }

}