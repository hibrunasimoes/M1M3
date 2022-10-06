using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepositorio _saleRepositorio;

        public SaleService(ISaleRepositorio saleRepositorio)
        {
            _saleRepositorio = saleRepositorio;
        }

        public void Atualizar(SaleDTO sale)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(SaleDTO sale)
        {
            throw new NotImplementedException();
        }

        public SaleDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Sale> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

