using DEVinCar.Api.DTOs;

namespace DEVinCar.Api.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public virtual User UserBuyer { get; set; }
        public virtual User UserSeller { get; set; }
        public virtual List<SaleCar> Cars { get; set; }
        public virtual List<Delivery> Deliveries { get; set; }      
        public Sale()
        {
        }

        public Sale(SaleDTO sale)
        {
            BuyerId = sale.BuyerId;
            SaleDate = sale.SaleDate;
        }

        public void Update(SaleDTO sale)
        {
            BuyerId = sale.BuyerId;
            SaleDate = sale.SaleDate;
        }
    }
}