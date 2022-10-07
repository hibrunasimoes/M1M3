
using System.Data;
using DEVinCar.Api.Config;
using DEVinCar.Api.Data;
using DEVinCar.Api.DTOs;
using DEVinCar.Api.Models;
using DEVinCar.Domain.Interfaces.Services;
using DEVinCar.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DEVinCar.Api.Controllers;

[ApiController]
[Route("api/car")]
[Authorize(Roles = "Gerente")]
public class CarController : ControllerBase
{
    private readonly CacheService<CarDTO> _carCache;

    private readonly ICarService _carService;

    public CarController(ICarService carService, CacheService<CarDTO> carCache)
    {
        carCache.Config("car", new TimeSpan(0, 2, 0));
        _carCache = carCache;
        _carService = carService;
    }


    [HttpGet("{carId}")]
    public ActionResult<Car> GetById([FromRoute] int id)
    {
        CarDTO car;
        if (!_carCache.TryGetValue($"{id}", out car))
        {
            car = _carService.ObterPorId(id);
            _carCache.Set(id.ToString(), car);
        }
        return Ok(car);
    }

    [HttpGet]
    public ActionResult<List<Car>> Get(
        [FromQuery] string name,
        [FromQuery] decimal? priceMin,
        [FromQuery] decimal? priceMax
    )
    {
        var cars = _carService.ObterTodos(name, priceMin, priceMax);
        if (!cars.Any())
        {
            return NoContent();
        }
        return Ok(cars);
    }

    [HttpPost]
    public ActionResult<Car> Post(
        [FromBody] CarDTO car
    )
    {
        _carService.Inserir(car);
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpDelete("{carId}")]
    public ActionResult Delete([FromRoute] int id)
    {
        _carService.Excluir(id);
        _carCache.Remove($"{id}");
        return StatusCode(StatusCodes.Status204NoContent);
    }

    //[HttpPut("{carId}")]
    //public ActionResult<Car> Put([FromBody] CarDTO carDto, [FromRoute] int carId)
    //{
    //    var car = _context.Cars.Find(carId);
    //    var name = _context.Cars.Any(c => c.Name == carDto.Name && c.Id != carId);


    //    if (car == null)
    //        return NotFound();
    //    if (carDto.Name.Equals(null) || carDto.SuggestedPrice.Equals(null))
    //        return BadRequest();
    //    if (carDto.SuggestedPrice <= 0)
    //        return BadRequest();
    //    if (name)
    //        return BadRequest();

    //    car.Name = carDto.Name;
    //    car.SuggestedPrice = carDto.SuggestedPrice;

    //    _context.SaveChanges();
    //    return NoContent();
    //}
}
