using JustSell.Bussiness.Common.DTOs;
using MediatR;
using System;

namespace JustSell.Bussiness.Requests.Queries
{
    public class CarByIdQuery : IRequest<CarDto>
    {
        public Guid Id { get; set; }
    }
}
