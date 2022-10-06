using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class UserServico : IUserServico
    {
        private readonly IUserRepositorio _userRepositorio;
        private readonly ISaleRepositorio _saleRepositorio;

        public UserServico(IUserRepositorio userRepositorio, ISaleRepositorio saleRepositorio)
        {
            _userRepositorio = userRepositorio;
            _saleRepositorio = saleRepositorio;
        }

        public void Atualizar(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public List<Sale> ObterBuy(int userid)
        {
            throw new NotImplementedException();
        }

        public UserDTO ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sale> ObterSales(int userid)
        {
            throw new NotImplementedException();
        }

        public IList<User> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
