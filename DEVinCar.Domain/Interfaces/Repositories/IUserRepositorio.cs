using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface IUserRepositorio
    {
        IList<User> ObterTodos();

        User ObterPorId(int id);

        void Inserir(User user);

        void Atualizar(User user);

        void Excluir(User user);

        //public User ObterPorUsuario(string email, string password);
    }
}

