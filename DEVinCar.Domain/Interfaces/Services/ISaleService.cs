using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface ISaleService
    {
        IList<Sale> ObterTodos();
        SaleDTO ObterPorId(int id);
        void Inserir(SaleDTO sale);
        void Excluir(int id);
        void Atualizar(SaleDTO sale);
    }
}

