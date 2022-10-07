using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Exceptions;
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
            var carDb = _carRepositorio.ObterPorId(car.Id);
            carDb.Update(car);
            _carRepositorio.Atualizar(carDb);
        }

        public void Excluir(int id)
        {
            var car = _carRepositorio.ObterPorId(id);
            _carRepositorio.Excluir(car);
        }

        public void Inserir(CarDTO car)
        {
            if (_carRepositorio.ExisteCarro(car.Id))
                throw new DuplicadoException("Carro já existe");

            _carRepositorio.Inserir(new Car(car));
        }

        public CarDTO ObterPorId(int id)
        {
            return new CarDTO(_carRepositorio.ObterPorId(id));

        }

        public IList<Car> ObterTodos(string name, decimal? priceMin, decimal? priceMax)
        {
            var query = _carRepositorio.QueryMetodo();
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(c => c.Name.Contains(name));
            }
            //if (priceMin > priceMax)
            //{
            //    return BadRequest();
            //}
            if (priceMin.HasValue)
            {
                query = query.Where(c => c.SuggestedPrice >= priceMin);
            }
            if (priceMax.HasValue)
            {
                query = query.Where(c => c.SuggestedPrice <= priceMax);
            }
            return query.ToList();
        }
    }
}
