using JustSell.Bussiness.Common.DTOs;
using JustSell.Bussiness.Requests.Commands;
using JustSell.Bussiness.Requests.Queries;
using JustSell.Data.Entities.Car;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JustSell.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public ProductController(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("car")]
        public async Task<IEnumerable<CarDto>> Get(CarsQuery query)
        {
            _logger.LogInformation("Get all cars");
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        [Route("car")]
        public async Task<CarDto> Get(CarByIdQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        [Route("car")]
        public async Task<Car> Post(AddCarCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
