using DEVinCar.Api.Models;
using DEVinCar.Api.Data;
using DEVinCar.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Runtime.ConstrainedExecution;
using Microsoft.AspNetCore.Authorization;
using DEVinCar.Domain.Interfaces.Services;

namespace DEVinCar.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/deliver")]
    public class DeliverController : ControllerBase
    {
        //private readonly DevInCarDbContext _context;

        //public DeliverController(DevInCarDbContext context)
        //{
        //    _context = context;
        //}

        private readonly IDeliveryService _deliveryService;
        public DeliverController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }


        [HttpGet]
        public ActionResult<Delivery> Get(
        [FromQuery] int? addressId,
        [FromQuery] int? saleId)
        {
            var query = _deliveryService.QueryMetodo();

            return Ok(query.ToList());
       
        }
    }
}

