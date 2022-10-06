using DEVinCar.Api.DTOs;

namespace DEVinCar.Api.Models
{
    public class City
    {        
        public int Id { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; }
        public virtual State State { get; set; }

        public virtual List<Address> Addresses { get; set; }

        public City()
        {
        }

        public City(CityDTO city)
        {
            Id = city.Id;
            StateId = city.StateId;
            Name = city.Name;
        }

        public void Update(CityDTO city)
        {

            Name = city.Name;

        }
    }
}
