using JustSell.Data.Entities.Base;
using JustSell.Data.Enums.Car;
using System.Collections.Generic;

namespace JustSell.Data.Entities.Car
{
    public class Engine : BaseEntity
    {
        public string Name { get; set; }
        public EngineType Type { get; set; }
        public double Capacity { get; set; }
        public int HorsePower { get; set; }

        public virtual ICollection<Car> Cars { get;set; }
    }
}
