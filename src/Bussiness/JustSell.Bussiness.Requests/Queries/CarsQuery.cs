using JustSell.Bussiness.Common.DTOs;
using MediatR;
using System.Collections.Generic;

namespace JustSell.Bussiness.Requests.Queries
{
    public class CarsQuery : IRequest<IEnumerable<CarDto>>
    {
    }
}
