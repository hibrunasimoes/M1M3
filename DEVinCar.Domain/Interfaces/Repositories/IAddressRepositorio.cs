using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface IAddressRepositorio
    {
        IList<Address> ObterTodos();

        Address ObterPorId(int id);

        void Excluir(Address address);
    }
}

