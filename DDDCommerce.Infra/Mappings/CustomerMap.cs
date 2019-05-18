using DDDCommerce.Domain.Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerce.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {

        public CustomerMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Document).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.MailAddress).IsRequired().HasMaxLength(50);
            Property(x => x.Name.FirstName).HasMaxLength(60);
            Property(x => x.Name.LastName).HasMaxLength(60);
            Property(x => x.Phone).HasMaxLength(14);
        }
    }
}
