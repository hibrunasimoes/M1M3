using System.ComponentModel.DataAnnotations;
using DEVinCar.Api.Models;

namespace DEVinCar.Api.DTOs
{
    public class SaleCarDTO
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Amount { get; set; }
        public int SaleId { get; set; }

        public SaleCarDTO()
        {

        }

        public SaleCarDTO(SaleCar saleCar)
        {
            Id = saleCar.Id;
            CarId = saleCar.CarId;
            UnitPrice = saleCar.UnitPrice;
            Amount = saleCar.Amount;
            SaleId = saleCar.SaleId;

        }
    }
}
