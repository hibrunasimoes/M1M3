using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface IStateService
    {
        IList<State> ObterTodos();
        StateDTO ObterPorId(int id);
        void Inserir(StateDTO state);
        void Atualizar(StateDTO city);
    }
}

