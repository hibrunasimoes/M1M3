using System;
using DEVinCar.Api.Data;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Data.Repositories
{
    public class UserRepositorio : BaseRepositorio<User, int>, IUserRepositorio
    {
        public UserRepositorio(DevInCarDbContext contexto) : base(contexto)
        {

        }

        public List<Sale> ObterBuy(int userid)
        {
            throw new NotImplementedException();
        }

        public User ObterPorUsuario(string email, string password)
        {
            return _contexto.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<Sale> ObterSales(int userid)
        {
            throw new NotImplementedException();
        }
    }
}

