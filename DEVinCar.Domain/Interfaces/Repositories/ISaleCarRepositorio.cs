using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{

    public interface ISaleCarRepositorio
    {
        IList<SaleCar> ObterTodos();

        SaleCar ObterPorId(int id);

        //public int ObterTotal();

        void Inserir(SaleCar sale);

        void Atualizar(SaleCar sale);
    }
}

