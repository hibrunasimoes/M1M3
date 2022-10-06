using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepositorio _addressRepositorio;

        public AddressService(IAddressRepositorio addressRepositorio)
        {
            _addressRepositorio = addressRepositorio;
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public AdressDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Address> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
