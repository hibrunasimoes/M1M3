using DEVinCar.Api.DTOs;

namespace DEVinCar.Api.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SuggestedPrice { get; set; }
        public virtual List<SaleCar> Sales { get; set; }
        public Car ()
        {
        }
        public Car(int id, string name, decimal suggestedPrice)
        {
            Id = id;
            Name = name;
            SuggestedPrice = suggestedPrice;
        }

        public Car(CarDTO car)
        {
            //Id = car.Id;
            Name = car.Name;
            SuggestedPrice = car.SuggestedPrice;
        }

        public void Update(CarDTO car)
        {
            //Id = car.Id;
            Name = car.Name;
            SuggestedPrice = car.SuggestedPrice;
        }
    }
}