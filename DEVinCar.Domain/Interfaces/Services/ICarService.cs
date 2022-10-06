﻿using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface ICarService
    {
        IList<Car> ObterTodos(string name, decimal? priceMin, decimal? priceMax);
        CarDTO ObterPorId(int id);
        void Inserir(CarDTO car);
        void Excluir(int id);
        void Atualizar(CarDTO car);
    }
}
