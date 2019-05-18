using DDDCommerce.Domain.Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerce.Infra.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Number);
            Property(x => x.Status);
            Property(x => x.CreateDate);

            HasRequired(x => x.Customer);
            HasMany(x => x.Items);

        }
    }
}
