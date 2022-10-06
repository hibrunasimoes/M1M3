using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface ICarRepositorio
    {
        IList<Car> ObterTodos();

        Car ObterPorId(int id);

        void Inserir(Car car);

        void Atualizar(Car car);

        void Excluir(Car car);

        //IQueryable<Car> Query();

        bool ExisteCarro(int id);


    }
}

