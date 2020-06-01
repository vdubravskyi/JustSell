using JustSell.Data.Entities.Car;
using JustSell.Data.Enums.Base;
using MediatR;
using System;
using System.Drawing;

namespace JustSell.Bussiness.Requests.Commands
{
    public class AddCarCommand : IRequest<Car>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public KnownColor Color { get; set; }

        public double Price { get; set; }
        public ProductState State { get; set; }
        public ProductCategory Category { get; set; }

        public Guid EngineId { get; set; }
    }
}
