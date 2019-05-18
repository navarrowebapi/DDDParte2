using DDDCommerce.Domain.Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerce.Infra.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Description).IsRequired();
            Property(x => x.Image);
            Property(x => x.Price).HasColumnType("money");
            Property(x => x.QuantityOnHand);
            Property(x => x.Title).IsRequired();

        }
    }
}
