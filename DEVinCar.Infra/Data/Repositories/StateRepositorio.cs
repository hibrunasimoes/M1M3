using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class StateRepositorio : BaseRepositorio<State, int>, IStateRepositorio
    {
        public StateRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }
    }
}

