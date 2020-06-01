using AutoMapper;
using JustSell.Bussiness.Common.DTOs;
using JustSell.Bussiness.Requests.Queries;
using JustSell.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JsutSell.Bussiness.Handlers.QueryHandlers
{
    public class CarQueryHandler : IRequestHandler<CarsQuery, IEnumerable<CarDto>>, IRequestHandler<CarByIdQuery, CarDto>
    {
        private readonly MainDBContext _context;
        private readonly IMapper _mapper;

        public CarQueryHandler(MainDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarDto>> Handle(CarsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars
                .Select(x => _mapper.Map<CarDto>(x))
                .ToListAsync();
        }

        public async Task<CarDto> Handle(CarByIdQuery request, CancellationToken cancellationToken)
        {
            var entityToMap = await _context.Cars
                .FirstOrDefaultAsync(x => x.Id == request.Id);

            return _mapper.Map<CarDto>(entityToMap);
        }
    }
}
