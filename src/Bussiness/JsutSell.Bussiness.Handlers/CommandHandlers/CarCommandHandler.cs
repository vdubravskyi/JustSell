using AutoMapper;
using JustSell.Bussiness.Requests.Commands;
using JustSell.Data;
using JustSell.Data.Entities.Car;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace JsutSell.Bussiness.Handlers.CommandHandlers
{
    public class CarCommandHandler : IRequestHandler<AddCarCommand, Car>
    {
        private readonly MainDBContext _context;

        public CarCommandHandler(MainDBContext context, IMapper mapper)
        {
            _context = context;
        }

        public async Task<Car> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            var createdEntity = await _context.AddAsync(new Car
            {
                Id = new Guid(),
                CreationDate = DateTime.Now,
                ModifyingDate = DateTime.Now,
                Price = request.Price,
                State = request.State,
                Category = request.Category,
                Brand = request.Brand,
                Model = request.Model,
                Year = request.Year,
                Color = request.Color,
                EngineId = request.EngineId
            });

            await _context.SaveChangesAsync(cancellationToken);

            return createdEntity.Entity;
        }
    }
}