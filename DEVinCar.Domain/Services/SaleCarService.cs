using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class SaleCarService : ISaleCarService
    {
        private readonly ISaleCarRepositorio _salecarRepositorio;

        public SaleCarService(ISaleCarRepositorio salecarRepositorio)
        {
            _salecarRepositorio = salecarRepositorio;
        }

        public void Atualizar(SaleCarDTO car)
        {
            throw new NotImplementedException();
        }

        public void Inserir(SaleCarDTO car)
        {
            throw new NotImplementedException();
        }

        public SaleCarDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SaleCar> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}