using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class CarRepositorio : BaseRepositorio<Car, int>, ICarRepositorio
    {
        public CarRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }

        public bool ExisteCarro(int id)
        {
            return _contexto.Cars.Any(x => x.Id == id);
        }

        //public List<Car> ObterPorNome(string nome)
        //{
        //    return _contexto.Cars.Where(x => x.Name == nome).ToList();
        //}

        //public IQueryable<Car> Query()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

