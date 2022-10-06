using System.ComponentModel.DataAnnotations;
using DEVinCar.Api.Models;

namespace DEVinCar.Api.DTOs
{
    public class SaleDTO
    {
        [Required(ErrorMessage = "The BuyerId is required.")]
        public int BuyerId { get; set; }
        public DateTime SaleDate { get; set; }

        SaleDTO()
        {

        }

        public SaleDTO(Sale sale)
        {
            BuyerId = sale.BuyerId;
            SaleDate = sale.SaleDate;
        }
    }
}
