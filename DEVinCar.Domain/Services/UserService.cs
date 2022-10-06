using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositorio _userRepositorio;
        private readonly ISaleRepositorio _saleRepositorio;

        public UserService(IUserRepositorio userRepositorio, ISaleRepositorio saleRepositorio)
        {
            _userRepositorio = userRepositorio;
            _saleRepositorio = saleRepositorio;
        }

        public void Atualizar(UserDTO user)
        {
            var userDb = _userRepositorio.ObterPorId(user.Id);
            userDb.Update(user);
            _userRepositorio.Atualizar(userDb);
        }

        public void Excluir(int id)
        {
            var user = _userRepositorio.ObterPorId(id);
            _userRepositorio.Excluir(user);
        }

        public void Inserir(UserDTO user)
        {
            //var oldUser = _userRepositorio.ObterPorUsuario(user.Email, user.Password);

            //if (oldUser != null)
            //_userRepositorio.Inserir(new User(user));
        }

        public List<Sale> ObterBuy(int userid)
        {
            return _saleRepositorio.ObterBuy(userid);
        }

        public UserDTO ObterPorId(int id)
        {
            return new UserDTO(_userRepositorio.ObterPorId(id));
        }

        public List<Sale> ObterSales(int userid)
        {
            return _saleRepositorio.ObterSales(userid);
        }

        public IList<User> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
