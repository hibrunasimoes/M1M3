using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepositorio _deliveryRepositorio;

        public DeliveryService(IDeliveryRepositorio deliveryRepositorio)
        {
            _deliveryRepositorio = deliveryRepositorio;
        }

        public DeliveryDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Delivery> ObterTodos(int? id, int? addressId, int? saleId)
        {
            throw new NotImplementedException();
        }
    }
}

