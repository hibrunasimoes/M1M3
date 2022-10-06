using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepositorio _carRepositorio;

        public CarService(ICarRepositorio carRepositorio)
        {
            _carRepositorio = carRepositorio;
        }

        public void Atualizar(CarDTO car)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(CarDTO car)
        {
            throw new NotImplementedException();
        }

        public CarDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Car> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
