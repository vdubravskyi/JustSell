using JustSell.Data.Enums.Base;

namespace JustSell.Data.Entities.Base
{
    public class BaseProductEntity : BaseEntity
    {
        public double Price { get; set; }
        public ProductState State { get; set; }
        public ProductCategory Category { get; set; }
    }
}
