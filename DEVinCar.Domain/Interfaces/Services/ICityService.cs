using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface ICityService
    {
        IList<City> ObterTodos();
        CityDTO ObterPorId(int id);
        void Inserir(CityDTO city);
        void Excluir(int id);
        void Atualizar(CityDTO city);
    }
}

