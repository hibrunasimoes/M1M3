using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{

    public class CityService : ICityService
    {
        private readonly ICityRepositorio _cityRepositorio;

        public CityService(ICityRepositorio cityRepositorio)
        {
            _cityRepositorio = cityRepositorio;
        }

        public void Atualizar(CityDTO city)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(CityDTO city)
        {
            throw new NotImplementedException();
        }

        public CityDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<City> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

