using System;
namespace DEVinCar.Domain.Exceptions
{

    public class DuplicadoException : Exception
    {
        public DuplicadoException(string nome) : base(nome)
        {

        }
    }
}
