using System.ComponentModel.DataAnnotations;
using DEVinCar.Api.Models;

namespace DEVinCar.Api.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        [MaxLength(255)]
        public string Name { get; set; }
        public decimal SuggestedPrice { get; set; }

        public CarDTO()
        {

        }
        public CarDTO(Car car)
        {
            //Id = car.Id;
            Name = car.Name;
            SuggestedPrice = car.SuggestedPrice;

        }

    }
}
