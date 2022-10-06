using System;
using DEVinCar.Api.Models;

namespace DEVinCar.Domain.DTOs
{
    public class UserLoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public UserLoginDTO()
        {
        }

        public UserLoginDTO(User user)
        {
            Email = user.Email;
            Password = user.Password;
        }
    }
}

