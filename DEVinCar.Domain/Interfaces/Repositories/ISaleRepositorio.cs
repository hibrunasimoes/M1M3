using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{

    public interface ISaleRepositorio
    {
        IList<Sale> ObterTodos();

        Sale ObterPorId(int id);

        void Inserir(Sale sale);

        void Atualizar(Sale sale);

        void Excluir(Sale sale);

        List<Sale> ObterSales(int userid);

        List<Sale> ObterBuy(int id);
    }
}

