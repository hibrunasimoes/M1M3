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
            return new DeliveryDTO(_deliveryRepositorio.ObterPorId(id));
        }

        public IList<Delivery> ObterTodos(int? id, int? addressId, int? saleId)
        {
            var query = _deliveryRepositorio.QueryMetodo();

            if (addressId.HasValue)
            {
                query = query.Where(a => a.AddressId == addressId);
            }

            if (saleId.HasValue)
            {
                query = query.Where(s => s.SaleId == saleId);
            }

            return query.ToList();
        }

        public IQueryable<Delivery> QueryMetodo()
        {
            throw new NotImplementedException();
        }
    }
}

