using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface ICityRepositorio
    {
        IList<City> ObterTodos();

        City ObterPorId(int id);

        void Inserir(City city);

        void Atualizar(City city);

        void Excluir(City city);
    }
}

