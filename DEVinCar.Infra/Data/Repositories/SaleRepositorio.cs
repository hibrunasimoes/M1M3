using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{

    public class SaleRepositorio : BaseRepositorio<Sale, int>, ISaleRepositorio
    {
        public SaleRepositorio(DevInCarDbContext contexto) : base(contexto)
        {
        }

        public List<Sale> ObterBuy(int userId)
        {
            var sales = _contexto.Sales.Where(s => s.BuyerId == userId);
            return (sales.ToList());
        }

        public List<Sale> ObterSales(int userId)
        {
            var sales = _contexto.Sales.Where(s => s.SellerId == userId);
            return (sales.ToList());
        }
    }
}

