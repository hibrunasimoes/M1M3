using System.Security.AccessControl;
using System;
using Microsoft.EntityFrameworkCore;
using DEVinCar.Api.DTOs;

namespace DEVinCar.Api.Models;
public class Delivery
{
    public int Id { get; set; }
    public DateTime DeliveryForecast { get; set; }
    public int AddressId { get; set; }
    public int SaleId { get; set; }
    public virtual Address Address { get; set; }
    public virtual Sale Sale { get; set; }
    public Delivery()
    {
    }

    public Delivery(DeliveryDTO delivery)
    {
        AddressId = (int)delivery.AddressId;
        DeliveryForecast = (DateTime)delivery.DeliveryForecast;
    }

    public void Update(DeliveryDTO delivery)
    {
        AddressId = (int)delivery.AddressId;
        DeliveryForecast = (DateTime)delivery.DeliveryForecast;
    }
}
