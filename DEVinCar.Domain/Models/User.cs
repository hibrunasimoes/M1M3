using DEVinCar.Api.DTOs;
using DEVinCar.Domain.Enums;
using System.Data;

namespace DEVinCar.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Permissoes Role { get; set; }

        public User()
        {

        }
        public User(int id, string email, string password, string name, DateTime birthDate)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            BirthDate = birthDate;
        }


        public User(UserDTO user)
        {
            Name = user.Name;
            Email = user.Email;
            Password = user.Password;
            BirthDate = user.BirthDate;
            Role = user.Role;
        }

        public void Update(UserDTO user)
        {
            Name = user.Name;
            Email = user.Email;
            Password = user.Password;
            BirthDate = user.BirthDate;
            Role = user.Role;
        }

        public User(int id, string email, string password, string name, DateTime birthDate, Permissoes role) : this(id, email, password, name, birthDate)
        {
            Role = role;
        }
    }
}