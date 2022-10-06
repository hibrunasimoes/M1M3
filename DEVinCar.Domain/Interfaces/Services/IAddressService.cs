using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface IAddressService
    {
        IList<Address> ObterTodos();
        AdressDTO ObterPorId(int id);
        void Excluir(int id);
    }
}

