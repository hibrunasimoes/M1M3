using System;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface IUserService
    {
        IList<User> ObterTodos();
        UserDTO ObterPorId(int id);
        void Inserir(UserDTO user);
        void Excluir(int id);
        void Atualizar(UserDTO user);
        List<Sale> ObterSales(int userid);
        List<Sale> ObterBuy(int userid);
        //User ObterPorUsuario(UserLoginDTO user);

    }
}

