using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class StateService : IStateService
    {
        private readonly IStateRepositorio _stateRepositorio;

        public StateService(IStateRepositorio stateRepositorio)
        {
            _stateRepositorio = stateRepositorio;
        }

        public void Atualizar(StateDTO city)
        {
            throw new NotImplementedException();
        }

        public void Inserir(StateDTO state)
        {
            throw new NotImplementedException();
        }

        public StateDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<State> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

