using JustSell.Data.Entities.Base;
using System;
using System.Drawing;

namespace JustSell.Data.Entities.Car
{
    public class Car : BaseProductEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public KnownColor Color { get; set; }

        public Guid EngineId { get; set; }
        public virtual Engine Engine { get; set; }
    }
}
