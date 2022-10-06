using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface ISaleCarService
    {
        IList<SaleCar> ObterTodos();
        SaleCarDTO ObterPorId(int id);
        void Inserir(SaleCarDTO car);
        void Atualizar(SaleCarDTO car);
    }
}

