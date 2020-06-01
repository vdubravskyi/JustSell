using System;

namespace JustSell.Data.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifyingDate { get; set; }
    }
}
